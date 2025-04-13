using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using Microsoft.VisualBasic.ApplicationServices;
using System.CodeDom;
using System.Data;
using System.Windows.Forms;
namespace BUS
{
    public static class PromotionBUS
    {
        public static List<Voucher> getVoucher()
        {
            return PromotionDAL.GetVoucherList();
        }

        public static DataTable GetVoucherDataTable()
        {
            List<Voucher> vouchers = PromotionDAL.GetVoucherList();
            return DataTableHelper.ToDataTable(vouchers);
        }
        private static string GenerateVoucherId(DateTime releaseDate, bool isCash)
        {
            string datePart = releaseDate.ToString("ddMMyy"); // e.g., 241224
            string typeChar = isCash ? "C" : "P";
            string prefix = $"V{datePart}{typeChar}";

            DataTable dataTable = PromotionDAL.getLatestId(prefix) ;
            int maxNumber = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                string vid = row["VoucherId"].ToString();
                if (vid.Length == 10 && int.TryParse(vid.Substring(7, 3), out int num))
                {
                    if (num > maxNumber) maxNumber = num;
                }
            }

            // Increment and format with leading zeros
            int nextNumber = maxNumber + 1;
            string numberPart = nextNumber.ToString("D3"); // Always 3 digits
            string nextId = $"{datePart}{typeChar}{nextNumber:D3}"; // e.g., 240412C002

            return nextId;
        }


        public static void addVoucher(string voucherName, string _applyAmount,string _discountValue,string _maxApply, bool isCash, DateTime from, DateTime to)
        {
            int applyAmount = int.TryParse(_applyAmount.Replace(",", ""), out var a)
                ? a : throw new Exception("Nhập lại mức áp dụng");
            int discountValue = int.TryParse(_discountValue.Replace(",", ""), out var d)
                ? d : throw new Exception("Nhập lại số lượng giảm");
            int maxApply = int.TryParse(_maxApply.Replace(",", ""), out var m)
                ? m : throw new Exception("Nhập lại mức giảm tối đa");


            //tránh nhập sai, sử dụng sai
            if (string.IsNullOrEmpty(voucherName)) {
                throw new Exception("Vui lòng nhập tên Voucher");
            }
            if (applyAmount < 0 || discountValue < 0||maxApply < 0)
            {
                throw new Exception("Tiền không thể âm");
            }
            if ((!isCash && (discountValue >= 100))
                ||(discountValue <= 0))
            {
                throw new Exception("Số lượng giảm không được vượt hay bằng 100%");
            }
            if (isCash)
            {
                if (discountValue != maxApply)
                {
                    throw new Exception("Khi giảm tiến, số lượng giảm phải bằng số lượng giảm tối đa");
                }
                 if (discountValue >= applyAmount || maxApply >= applyAmount)
                {
                    throw new Exception("Số lượng giảm không được nhiều hơn mức áp dụng");
                }
            }
            else
            {
                if (maxApply >= applyAmount)
                {
                    throw new Exception("Số lượng giảm không được nhiều hơn mức");
                }
            }
           
            if (((from < DateTime.Today) || (to < DateTime.Today)))
                throw new Exception("Thời gian áp dụng không thể ở quá khứ");
            if ((from > to))
                throw new Exception("Vui lòng nhập đúng thời gian");

            string id = GenerateVoucherId(from,isCash);
            PromotionDAL.addVoucher(id,voucherName,applyAmount,discountValue,maxApply,isCash,to,from);
        }

        public static void editVoucher(string voucherId, string voucherName, string _applyAmount, string _discountValue, string _maxApply, bool isCash, DateTime from, DateTime to)
        {
            int applyAmount = int.TryParse(_applyAmount.Replace(",", ""), out var a)
                ? a : throw new Exception("Nhập lại mức áp dụng");
            int discountValue = int.TryParse(_discountValue.Replace(",", ""), out var d)
                ? d : throw new Exception("Nhập lại số lượng giảm");
            int maxApply = int.TryParse(_maxApply.Replace(",", ""), out var m)
                ? m : throw new Exception("Nhập lại mức giảm tối đa");

            //tránh nhập sai, sử dụng sai
            if (string.IsNullOrEmpty(voucherName))
            {
                throw new Exception("Vui lòng nhập tên Voucher");
            }
            if (applyAmount < 0 || discountValue < 0 || maxApply < 0)
            {
                throw new Exception("Tiền không thể âm");
            }
            if ((!isCash && (discountValue >= 100))
                || (discountValue <= 0))
            {
                throw new Exception("Số lượng giảm không được vượt hay bằng 100%");
            }
            if (isCash)
            {
                if (discountValue != maxApply)
                {
                    throw new Exception("Khi giảm tiến, số lượng giảm phải bằng số lượng giảm tối đa");
                }
                if (discountValue >= applyAmount || maxApply >= applyAmount)
                {
                    throw new Exception("Số lượng giảm không được nhiều hơn mức áp dụng");
                }
            }
            else
            {
                if (maxApply >= applyAmount)
                {
                    throw new Exception("Số lượng giảm không được nhiều hơn mức");
                }
            }

            //if (((from < DateTime.Today) || (to < DateTime.Today)))
            //    throw new Exception("Thời gian áp dụng không thể ở quá khứ");
            if ((from > to))
                throw new Exception("Vui lòng nhập đúng thời gian");



            PromotionDAL.editVoucher(voucherId,voucherName, applyAmount, discountValue, maxApply, isCash, to, from);
        }

        public static void deactivateVoucher(string voucherId)
        {
            Voucher voucher = PromotionDAL.GetVoucherList().FirstOrDefault(v => v.IsActive && v.VoucherId==voucherId);
            if (voucher == null)
            {
                throw new Exception("Không thể tìm thấy voucher hoặc voucher vốn dĩ đã không hoạt động");
            }
            else
            {
                PromotionDAL.deactivateVoucher(voucherId);
            }
        }
    }
}
