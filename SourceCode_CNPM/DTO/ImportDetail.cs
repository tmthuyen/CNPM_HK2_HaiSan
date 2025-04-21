
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace DTO{
    
    public class ImportDetail
    {
        public string ImportId { get; set; }
        public string ProductId { get; set; }
        public float Quantity { get; set; }
        public float Remaining { get; set; }
        public int PurchasePrice { get; set; }
        
        public DateTime Expire { get; set; }

        // tien phai tra cua chi tiet nhap vao
        public float TotalPrice => PurchasePrice * Quantity;

        public ImportDetail(string importId, string productId, float quantity, float remaining, int purchasePrice, DateTime expire)
        {
            ImportId = importId;
            ProductId = productId;
            Quantity = quantity;
            Remaining = remaining;
            PurchasePrice = purchasePrice;
            Expire = expire;
        }
    }

 }