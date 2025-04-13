
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{

    public class VoucherDTO
    {
        public string VoucherId { get; set; }
        public string VoucherName { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime Expire { get; set; }
        public int ApplyAmount { get; set; }
        public int MaxApply { get; set; }
        public int DiscountValue { get; set; }
        public bool IsCash { get; set; }

        // Constructor không tham số
        public VoucherDTO() { }

        // Constructor có tham số
        public VoucherDTO(string voucherId, string voucherName, DateTime releaseDate, DateTime expire,
                          int applyAmount, int maxApply, int discountValue, bool isCash)
        {
            VoucherId = voucherId;
            VoucherName = voucherName;
            ReleaseDate = releaseDate;
            Expire = expire;
            ApplyAmount = applyAmount;
            MaxApply = maxApply;
            DiscountValue = discountValue;
            IsCash = isCash;
        }
    }


}