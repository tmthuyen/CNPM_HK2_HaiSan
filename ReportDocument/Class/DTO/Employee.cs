using HaiSan;

namespace HaiSan.DTO
{
    public class Employee
    {
        public string EmployeeId { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Avatar { get; set; }
        public int Status { get; set; } = 1;
        public string PassWord { get; set; }
        public string RoleName { get; set; }
        public string Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public Employee(string employeeId, string fullName, string phone, string avatar, string passWord, string roleName, string gender, DateTime? dateOfBirth)
        {
            EmployeeId = employeeId;
            FullName = fullName;
            Phone = phone;
            Avatar = avatar;
            PassWord = passWord;
            RoleName = roleName;
            Gender = gender;
            DateOfBirth = dateOfBirth;
        }

        public void ToggleStatus() => Status = Status == 1 ? 0 : 1;
    }

    public class Customer
    {
        public string CustomerPhone { get; set; }
        public string FullName { get; set; }
        public int LoyaltyPoint { get; set; } = 0;

        public Customer(string phone, string fullName)
        {
            CustomerPhone = phone;
            FullName = fullName;
        }

        public void UpdateLoyaltyPoints(int points) => LoyaltyPoint += points;
    }

    public class Order
    {
        public string OrderId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public double TotalAmount { get; set; }
        public double ReceivedAmount { get; set; }
        public int UsedPoint { get; set; } = 0;
        public string PaymentMethod { get; set; }
        public Customer Customer { get; set; }
        public Employee Employee { get; set; }

        public Order(string orderId, double totalAmount, double receivedAmount, string paymentMethod, Customer customer, Employee employee)
        {
            OrderId = orderId;
            TotalAmount = totalAmount;
            ReceivedAmount = receivedAmount;
            PaymentMethod = paymentMethod;
            Customer = customer;
            Employee = employee;
        }


        public double GetChangeAmount() => ReceivedAmount - (TotalAmount - UsedPoint);
    }

    public class Product
    {
        public string ProductId { get; set; }
        public string Name { get; set; }
        public double PurchasePrice { get; set; }
        public double RetailPrice { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public int Quantity { get; set; } = 0;
        public DateTime? ExpireDate { get; set; }
        public bool Status { get; set; }
        public Category Category { get; set; }
        public Supplier Supplier { get; set; }

        public Product(string productId, string name, double purchasePrice, double retailPrice, int quantity, bool status, Category category, Supplier supplier)
        {
            ProductId = productId;
            Name = name;
            PurchasePrice = purchasePrice;
            RetailPrice = retailPrice;
            Quantity = quantity;
            Status = status;
            CategoryId = categoryId;
            SupplierId = supplierId;
        }

        public void UpdateQuantity(int amount) => Quantity += amount;
    }

    public class Category
    {
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }

        // 1-N: Một loại có nhiều sản phẩm
        // public List<Product> Products { get; set; } = new List<Product>();
    }

    public class OrderDetail
    {
        public Order Order { get; set; }
        public Product Product { get; set; }
        public int QuantitySold { get; set; }
        public double UnitPrice { get; set; }
        public double DiscountAmount { get; set; } = 0;

        public OrderDetail(Order order, Product product, int quantitySold, double unitPrice, double discountAmount)
        {
            Order = order;
            Product = product;
            QuantitySold = quantitySold;
            UnitPrice = unitPrice;
            DiscountAmount = discountAmount;
        }

        public double GetTotalPrice() => QuantitySold * UnitPrice;

        public double GetFinalPrice() => GetTotalPrice() - DiscountAmount;
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
        public DateTime ImportDate { get; set; } = DateTime.Now;
        public string SupplierId { get; set; }
        public double TotalAmount { get; set; }
    }

    public class ImportDetail
    {
        public string ImportId { get; set; }
        public string ProductId { get; set; }
        public int Quantity { get; set; }
        public double PurchasePrice { get; set; }

        public double GetTotalPrice() => Quantity * PurchasePrice;
    }

    public class PromotionGroup
    {
        public string GroupId { get; set; }
        public string GroupName { get; set; }
    }

    public class Promotion
    {
        public string PromotionId { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime ExpiredDate { get; set; }
        public double DiscountValue { get; set; }
        public string GroupId { get; set; }
    }

    public class OrderPromotion
    {
        public string OrderId { get; set; }
        public string PromotionId { get; set; }
    }

    public class Involves
    {
        public string GroupId { get; set; }
        public string ProductId { get; set; }
    }

    public class Restriction
    {
        public string PromotionId { get; set; }
        public string Type { get; set; }
        public string ApplyCondition { get; set; }
    }

}