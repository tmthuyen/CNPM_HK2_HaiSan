
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO{
    public class Product
    {
        public string ProductId { get; set; }
        public string SupplierId { get; set; }
        //public string ImportId { get; set; }
        //public string CategoryName { get; set; }
        public string CategoryId { get; set; }
        public string ProductName { get; set; }
        public int PurchasePrice { get; set; }
        public int RetailPrice { get; set; }
        public DateTime CreatedAt { get; set; }
        //public decimal Remaining { get; set; }
        public string Unit { get; set; }

        public Product() { }

        public Product(string productId, string supplierId, string categoryId, string productName, int purchasePrice,
                          int retailPrice, DateTime createdAt, string unit)
        {
            ProductId = productId;
            SupplierId = supplierId;
            CategoryId = categoryId;
            ProductName = productName;
            PurchasePrice = purchasePrice;
            RetailPrice = retailPrice;
            CreatedAt = createdAt; 
            Unit = unit;
        }

        //public Product(string productId, string supplierId, string categoryName, string productName, int purchasePrice,
        //                  int retailPrice, DateTime createdAt, decimal remaining, string unit)
        //{
        //    ProductId = productId;
        //    SupplierId = supplierId;
        //    CategoryName = categoryName;
        //    ProductName = productName;
        //    PurchasePrice = purchasePrice;
        //    RetailPrice = retailPrice;
        //    CreatedAt = createdAt;
        //    Remaining = remaining;
        //    Unit = unit;
        //}
        //public override string ToString()
        //{
        //    return this.ProductName + " | " + Remaining + " | " + ImportId;
        //}
    }
    
}