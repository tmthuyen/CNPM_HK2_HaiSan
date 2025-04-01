
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Employee
    {
        public string EmployeeId { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Avatar { get; set; }
        public int Status { get; set; }
        public string Password { get; set; }
        public string RoleName { get; set; }
        public string Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public Employee(string employeeId, string fullName, string phone, string avatar, int status, string password, string roleName, string gender, DateTime? dateOfBirth)
        {
            EmployeeId = employeeId;
            FullName = fullName;
            Phone = phone;
            Avatar = avatar;
            Status = status;
            Password = password;
            RoleName = roleName;
            Gender = gender;
            DateOfBirth = dateOfBirth;
        }
    }

    public class Customer
    {
        public string CustomerId { get; set; }
        public string CustomerPhone { get; set; }
        public string FullName { get; set; }
        public int LoyaltyPoint { get; set; }

        public Customer(string customerId, string customerPhone, string fullName, int loyaltyPoint)
        {
            CustomerId = customerId;
            CustomerPhone = customerPhone;
            FullName = fullName;
            LoyaltyPoint = loyaltyPoint;
        }


        public void updatePoint(double price)
        {
            LoyaltyPoint += (int)Math.Floor(price / 100);
        }

        public void usedPoint(int usedPoint)
        {
            LoyaltyPoint -= usedPoint;
        }
    }

    public class Order
    {
        public string OrderId { get; set; }
        public DateTime CreatedAt { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal ReceivedAmount { get; set; }
        public int UsedPoint { get; set; }
        public string PaymentMethod { get; set; }
        public string CustomerId { get; set; }
        public string EmployeeId { get; set; }


        //  tien phai phai tra
        public decimal FinalAmount => TotalAmount - UsedPoint;

        // tien thua
        public decimal ChangeAmount => ReceivedAmount - FinalAmount;

        // danh sach chi tiet hoa don
        public List<OrderDetail> OrderDetailList { get; set; } = new List<OrderDetail>();

        public Order(string orderId, DateTime createdAt, decimal totalAmount, decimal receivedAmount, int usedPoint, string paymentMethod, string customerId, string employeeId)
        {
            OrderId = orderId;
            CreatedAt = createdAt;
            TotalAmount = totalAmount;
            ReceivedAmount = receivedAmount;
            UsedPoint = usedPoint;
            PaymentMethod = paymentMethod;
            CustomerId = customerId;
            EmployeeId = employeeId;
        }

        // them chi tiet hoa don vao danh sach
        public void addOrderDetail(OrderDetail orderDetail)
        {
            if (orderDetail.OrderId.Equals(OrderId))
            {
                OrderDetailList.Add(orderDetail);
            }
        }

        // tinh tong tien cua hoa don
        public decimal getTotalAmount()
        {
            if (OrderDetailList.Count == 0) 
                return 0;
            return OrderDetailList.Sum(od => od.TotalAmount);
        }

    }

    public class OrderDetail
    {
        public string OrderId { get; set; }
        public string ProductId { get; set; }
        public int QuantitySold { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal DiscountAmount { get; set; }

        // tien phai tra cua chi tiet hoa don
        public decimal TotalAmount => QuantitySold * UnitPrice - DiscountAmount;

        public OrderDetail(string orderId, string productId, int quantitySold, decimal unitPrice, decimal discountAmount = 0)
        {
            OrderId = orderId;
            ProductId = productId;
            QuantitySold = quantitySold;
            UnitPrice = unitPrice;
            DiscountAmount = discountAmount;
        }

        
    }


    public class Product
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal RetailPrice { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedAt { get; set; }
        public int ExpirationPeriod { get; set; }
        public int Status { get; set; }
        public string CategoryId { get; set; }

        public Product(string productId, string productName, decimal purchasePrice, decimal retailPrice, DateTime createdAt, int quantity, int expirationPeriod, int status, string categoryId)
        {
            ProductId = productId;
            ProductName = productName;
            PurchasePrice = purchasePrice;
            RetailPrice = retailPrice;
            CreatedAt = createdAt;
            Quantity = quantity;
            ExpirationPeriod = expirationPeriod;
            Status = status;
            CategoryId = categoryId;
        }


        // tinh han su dung con lai cua san pham
        public int getRemainDate(DateTime dateTime)
        {
            return DateTime.Compare(DateTime.Now, dateTime);
        }

        // kiem tra han su dung
        public bool isExpired(DateTime dateTime)
        {
            return DateTime.Compare(DateTime.Now, dateTime) < ExpirationPeriod;
        }
    }

    public class Category
    {
        public string CategoryId { get; set; }

        public string CategoryName { get; set; }

        public Category(string categoryId, string categoryName)
        {
            CategoryId = categoryId;
            CategoryName = categoryName;
        }
    }


    public class Supplier
    {
        public string SupplierId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public Supplier(string supplierId, string name, string address, string email, string phone)
        {
            SupplierId = supplierId;
            Name = name;
            Address = address;
            Email = email;
            Phone = phone;
        }
    }

    public class Import
    {
        public string ImportId { get; set; }
        public DateTime ImportDate { get; set; }
        public string SupplierId { get; set; }
        public decimal TotalAmount { get; set; }

        // danh sach chi tiet nhap vao
        public List<ImportDetail> ImportDetailList { get; set; } = new List<ImportDetail>();

        public Import(string importId, DateTime importDate, string supplierId, decimal totalAmount)
        {
            ImportId = importId;
            ImportDate = importDate;
            SupplierId = supplierId;
            TotalAmount = totalAmount;
        }

        // them chi tiet nhap vao danh sach
        public void addImportDetail(ImportDetail importDetail)
        {
            if (importDetail.ImportId.Equals(ImportId))
            {
                ImportDetailList.Add(importDetail);
            }
        }

        // tinh tong tien cua hoa don nhap vao
        public decimal getTotalMount()
        {
            if(ImportDetailList.Count == 0)
                return 0;
            return ImportDetailList.Sum(id => id.TotalPrice);
        }
    }

    public class ImportDetail
    {
        public string ImportId { get; set; }
        public string ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal PurchasePrice { get; set; }

        // tien phai tra cua chi tiet nhap vao
        public decimal TotalPrice => PurchasePrice * Quantity;

        public ImportDetail(string importId, string productId, int quantity, decimal purchasePrice)
        {
            ImportId = importId;
            ProductId = productId;
            Quantity = quantity;
            PurchasePrice = purchasePrice;
        }
    }

    // while(true){Console.WriteLine("Co len");}
    public class PromotionGroup
    {
        public string GroupId { get; set; }
        public string GroupName { get; set; }

        public PromotionGroup(string groupId, string groupName)
        {
            GroupId = groupId;
            GroupName = groupName;
        }
    }

    public class Promotion
    {
        public string PromotionId { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime ExpiredDate { get; set; }
        public decimal DiscountValue { get; set; }
        public string GroupId { get; set; }

        public Promotion(string promotionId, DateTime releaseDate, DateTime expiredDate, decimal discountValue, string groupId)
        {
            PromotionId = promotionId;
            ReleaseDate = releaseDate;
            ExpiredDate = expiredDate;
            DiscountValue = discountValue;
            GroupId = groupId;
        }
    }

}