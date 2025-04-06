
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DTO{ 
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