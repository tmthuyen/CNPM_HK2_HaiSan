
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DTO{ 
    public class Voucher 
    {
        public string VoucherId { get; set; }
        public string VoucherName { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public int ApplyAmount { get; set; }
        public int MaxApply { get; set; }
        public int DiscountValue { get; set; }
        public bool IsCash { get; set; }
        public bool IsActive { get; set; }
        public Voucher() { }
        public Voucher(
        string voucherId,
        string voucherName,
        DateTime releaseDate,
        DateTime expireDate,
        int applyAmount,
        int maxApply,
        int discountValue,
        bool isCash
    )
        {
            VoucherId = voucherId;
            VoucherName = voucherName;
            ReleaseDate = releaseDate;
            ExpireDate = expireDate;
            ApplyAmount = applyAmount;
            MaxApply = maxApply;
            DiscountValue = discountValue;
            IsCash = isCash;
        }

    }



}