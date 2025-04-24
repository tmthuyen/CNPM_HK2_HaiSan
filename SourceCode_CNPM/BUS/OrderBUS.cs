using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using Microsoft.IdentityModel.Tokens;
namespace BUS
{
    public class OrderBUS
    {
        PromotionDAL promotionDAL = new PromotionDAL();
        ImportDetailDAL importDetailDAL = new ImportDetailDAL();
        OrderDAL orderDAL = new OrderDAL();
        public List<ProductImport> GetProductByLoHang()
        {
            return orderDAL.GetProductByLoHang();
        }

        public List<Order> GetOrders()
        {
            return orderDAL.GetAll();
        }

        public List<Order> Sort(string orderId, string phone, string employeeId, int priceStart, int priceEnd, string sortBy ="CreatedAt", bool ASC = false)
        {
            List<Order> orders = GetOrders();

            if (!string.IsNullOrEmpty(orderId))
                orders = orders.Where(o => o.OrderId.Contains(orderId)).ToList();

            if (!string.IsNullOrEmpty(phone))
                orders = orders.Where(o => o.Phone.Contains(phone)).ToList();

            if (!string.IsNullOrEmpty(employeeId))
                orders = orders.Where(o => o.EmployeeId == employeeId).ToList();

            if (priceStart > 0 || priceEnd > 0)
            {
                orders = orders.Where(o =>
                    o.TotalAmount >= (priceStart > 0 ? priceStart : 0) &&
                    o.TotalAmount <= (priceEnd > 0 ? priceEnd : decimal.MaxValue)).ToList();
            }
            orders = sortBy switch
            {
                "CreatedAt" => ASC ? orders.OrderBy(o => o.CreatedAt).ToList()
                                   : orders.OrderByDescending(o => o.CreatedAt).ToList(),

                "TotalAmount" => ASC ? orders.OrderBy(o => o.TotalAmount).ToList()
                                     : orders.OrderByDescending(o => o.TotalAmount).ToList(),

                _ => orders.OrderByDescending(o => o.CreatedAt).ToList() // fallback
            };
            return orders;
        }

        public List<Voucher> GetVouchers(int total)
        {
            List<Voucher> vouchers = promotionDAL.GetVoucherList();
            List<Voucher> filtered = vouchers.Where(v => v.ApplyAmount <= total && v.IsActive).ToList();
            return filtered;
        }

        public bool CheckAvailable(ProductImport product, decimal quantity)
        {
            if (product == null)
            {
                return false;
            }
            return (product.Remaining >= quantity);
        }

        //Mấy này dễ quá mà vẫn phải để trong đây ư ?!?
        public decimal AddAmounts(decimal a, decimal b) => a + b;
        public int GetRawTotal(int[] values) => values.Sum();
        public int CalChange(int total, int given) => (given - total);
        public decimal CalPrice(decimal amount, decimal price) => amount * price;
        public int CalOverAll(int raw, int voucherDiscount, int point) => (raw - voucherDiscount - point);
        public bool validPoint(int pointHas, int pointUse) => (pointHas >= pointUse);
        public bool validGiven(int given, int total) => (given>=total);
        public bool validPriceSort(int priceFrom, int PriceTo) => (priceFrom<=PriceTo);

        // liên quan đến customer
        public Customer GetCustomer(string phone)
        {
            if (phone == "000000000000" || phone.Length == 0)
                throw new Exception("Số điện thoại không hợp lệ");
            return orderDAL.GetCustomer(phone)??throw new Exception("Chưa là khách hàng");
        }

        public string GenerateCustomerId()
        {
            string[] ids = orderDAL.GetAllCustomerId();
            // lấy mấy id mà bắt đầu cùng ngày
            var cusIds = ids.Where(id => id.StartsWith("CUS")).ToList();

            int maxNumber = 0;
            foreach (string id in cusIds)
            {
                //lấy từ chữ số 7 trở đi để so sánh r lấy maxnumber
                if (id.Length == 10 && int.TryParse(id.Substring(3), out int number))
                {
                    if (number > maxNumber)
                    {
                        maxNumber = number;
                    }
                }
            }
            int newNumber = maxNumber + 1;
            string newId = "CUS" + newNumber.ToString("D7");

            return newId;
        }

        //Tính discount dựa trên voucher và tổng thuần túy
        //này là số lượng tiền giảm chứ ko phải số lượng sau giảm
        //kan chigai suru na!
        public int GetDiscount(int total, Voucher voucher)
        {
            //giảm vnd
            if (voucher.IsCash)
                return voucher.DiscountValue;

            //giảm %
            decimal discount = Math.Min(total * (voucher.DiscountValue / 100.0m), voucher.MaxApply);
            int finalDiscount = (int)discount;
            return finalDiscount;
        }

        //tạo đơn
        public void CreateOrder(string customerName, string phone, string voucherId, string employeeId,
                    int total, int received, int points, string payMethod, List<OrderDetail> orderDetails, List<ProductImport> products)
        {
            int pointGained = CalculatePoints(total);
            //check if already customer, then fix the points
            //if not generate a new id
            //then add into custoemr table 
            Customer customer= orderDAL.GetCustomer(phone);
            string customerId;
            if (customer==null)
            {
                customerId = GenerateCustomerId();
                try
                {
                    //even for anonymous people, it would only generate an id for the fisrt anonynous guy
                    orderDAL.insertCustomer(customerId, customerName, phone, pointGained);
                }
                catch (Exception ex)
                {
                    throw new Exception("Không thành công khi thêm khách hàng: " + ex.Message);
                }

            }
            else
            {
                customerId = customer.CustomerId;
                //Update tên khách hàng nếu sai
                if (customerName != customer.CustomerName)
                {
                    try
                    {
                        orderDAL.ChangeName(customer.CustomerId,customerName);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
                try
                {
                    // dòng check điều kiện này ở đây chỉ vì 00000000000 là thằng ẩn danh
                    // nên khỏi update nó
                    if (phone != "000000000000")
                    {
                        int pointHas = orderDAL.GetPoint(customer.CustomerId);
                        orderDAL.InsertPoint(customer.CustomerId, pointHas + pointGained - points);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            // we gotta find and gen the latest id first
            string orderId = GenerateOrderId();

            //we be inserting them orderid into them orderdetails
            foreach (OrderDetail orderDetail in orderDetails)
            {
                orderDetail.OrderId = orderId;
            }

            //order is created????
            Order newOrder = new Order
            {
                OrderId = orderId,
                CreatedAt = DateTime.Now,
                TotalAmount = total,
                ReceivedAmount = received,
                UsedPoint = points,
                PaymentMethod = payMethod,
                CustomerId = customerId,
                EmployeeId = employeeId,
                VoucherId = voucherId,
                OrderDetailList = orderDetails
            };
            if (!orderDAL.Add(newOrder))
            {
                throw new Exception("Add không thành công vì lý do nào đó.");
            }
            // update import detail
            foreach (OrderDetail orderDetail in orderDetails)
            {
                string productId = orderDetail.ProductId ;
                ProductImport p = products.Where(v => v.ProductId == productId).FirstOrDefault();
                string importId = orderDetail.ImportId ;
                decimal remaining = p.Remaining - orderDetail.Amount;
                try
                {
                    importDetailDAL.UpdateImportDetail(productId, importId, remaining);
                }
                catch(Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

        }




        public int CalculatePoints(int amount)
        {
            int points = (amount / 100000) * 1000;
            return points;
        }

        public string GenerateOrderId()
        {
            string[] ids = orderDAL.GetAllOrderId();
            // lấy mấy id mà bắt đầu cùng ngày
            string today = DateTime.Now.ToString("yyMMdd");
            string begin = "OR" + today;
            var todayIds = ids.Where(id => id.StartsWith(begin)).ToList();

            int maxNumber = 0;
            foreach (string id in todayIds)
            {
                if (id.Length == 12 && int.TryParse(id.Substring(8, 4), out int number))
                {
                    if (number > maxNumber)
                    {
                        maxNumber = number;
                    }
                }
            }
            int newNumber = maxNumber + 1;
            string newId = begin + newNumber.ToString("D4");

            return newId;
        }
<<<<<<< HEAD
    
            
        // báo cáo thông kê
        public DataTable GetNumOrder_Revenue_NumCus(DateTime fromDate, DateTime toDate)
        {
            return orderDAL.GetNumOrder_Revenue_NumCus(fromDate, toDate);
=======
        // trả về 1 list mà ko có duplicate
        public List<OrderItem> ConsolidateOrderItems(List<OrderItem> items)
        {
            var consolidated = items
                .GroupBy(item => item.Name)
                .Select(group => new OrderItem
                {
                    Name = group.Key,
                    Quantity = group.Sum(i => i.Quantity),
                    Unit = group.First().Unit,
                    Price = group.First().Price // khác lô nhưng cũng cùng giá (pretty sure)
                })
                .ToList();

            return consolidated;
>>>>>>> 3f56fa5 (Mostly finished order)
        }
    }

}
