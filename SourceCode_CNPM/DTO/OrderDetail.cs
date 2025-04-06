
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO{
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
}