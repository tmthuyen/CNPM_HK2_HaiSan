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
        OrderDAL orderDAL = new OrderDAL();
        public List<ProductImport> GetProductByLoHang()
        {
            return orderDAL.GetProductByLoHang();
        }

        public List<Product> Sort(List<Product> products, decimal? minPrice, decimal? maxPrice, string categoryId, string name, string sortBy = "RetailPrice", bool ascending = true)
        {
            // Filtering
            var filtered = products.Where(p =>
                (!minPrice.HasValue || p.RetailPrice >= minPrice.Value) &&
                (!maxPrice.HasValue || p.RetailPrice <= maxPrice.Value) &&
                (string.IsNullOrWhiteSpace(categoryId) || p.CategoryId == categoryId) &&
                (string.IsNullOrWhiteSpace(name) || p.ProductName.Contains(name, StringComparison.OrdinalIgnoreCase))
            );

            // Sorting
            filtered = sortBy switch
            {
                "ProductName" => ascending ? filtered.OrderBy(p => p.ProductName) : filtered.OrderByDescending(p => p.ProductName),
                "PurchasePrice" => ascending ? filtered.OrderBy(p => p.PurchasePrice) : filtered.OrderByDescending(p => p.PurchasePrice),
                "CreatedAt" => ascending ? filtered.OrderBy(p => p.CreatedAt) : filtered.OrderByDescending(p => p.CreatedAt),
                "Unit" => ascending ? filtered.OrderBy(p => p.Unit) : filtered.OrderByDescending(p => p.Unit),
                _ => ascending ? filtered.OrderBy(p => p.RetailPrice) : filtered.OrderByDescending(p => p.RetailPrice),
            };

            return filtered.ToList();
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
                    int total, int received, int points, string payMethod, List<OrderDetail> orderDetails)
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
                string importId = orderDetail.ImportId ;
                decimal remaining = orderDetail.Amount;
                try
                {
                    orderDAL.UpdateImportDetail(productId, importId, remaining);
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
    
            
        // báo cáo thông kê
        public DataTable GetNumOrder_Revenue_NumCus(DateTime fromDate, DateTime toDate)
        {
            return orderDAL.GetNumOrder_Revenue_NumCus(fromDate, toDate);
        }
    }

}
