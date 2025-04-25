using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProductImport
    {
        public string ProductId { get; set; }
        public string SupplierId { get; set; }
        public string ImportId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryId { get; set; }
        public string ProductName { get; set; }
        public int PurchasePrice { get; set; }
        public int RetailPrice { get; set; }
        public DateTime CreatedAt { get; set; }
        public decimal Remaining { get; set; }
        public string Unit { get; set; }

        public ProductImport() { }

        public override string ToString()
        {
            return ProductName.Trim() + " | " + Remaining + " | " + ImportId.Trim();
        }
    }
}
