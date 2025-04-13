using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DiscountDetail
    {
        public string PromotionId { get; set; }
        public string ProductId { get; set; }
        public int DiscountValue { get; set; }
        public bool IsCash { get; set; }
        public DiscountDetail(string promotionId, string productId, int discountValue, bool isCash)
        {
            PromotionId = promotionId;
            ProductId = productId;
            DiscountValue = discountValue;
            IsCash = isCash;
        }
        public DiscountDetail() { } 

    }
}
