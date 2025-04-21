
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class OrderDetail
    {
        public string OrderId { get; set; }
        public string ProductId { get; set; }
        public string ImportId { get; set; }
        public int RetailPrice { get; set; }
        public decimal Amount { get; set; }

        public OrderDetail() { }

        public OrderDetail(string orderId, string productId, int retailPrice, decimal amount)
        {
            OrderId = orderId;
            ProductId = productId;
            RetailPrice = retailPrice;
            Amount = amount;
        }

    }
}