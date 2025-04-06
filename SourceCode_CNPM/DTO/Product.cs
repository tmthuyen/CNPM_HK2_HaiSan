
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO{
    
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

        public Product() { }

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
}