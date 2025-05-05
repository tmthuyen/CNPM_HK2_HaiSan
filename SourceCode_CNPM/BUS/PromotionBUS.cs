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
    public class PromotionBUS
    {
        private readonly PromotionDAL promotionDAL;
        public PromotionBUS()
        {
            promotionDAL = new PromotionDAL();
        }
        public List<Voucher> GetVoucher()
        {
            return promotionDAL.GetVoucherList();
        }

        public DataTable GetVoucherDataTable()
        {
            return promotionDAL.GetVoucherDataTable();
        }
        private string GenerateVoucherId(DateTime releaseDate, bool isCash)
        {
            string datePart = releaseDate.ToString("yyMMdd"); // e.g., 241224
            string typeChar = isCash ? "C" : "P";
            string prefix = $"V{datePart}{typeChar}";

            DataTable dataTable = promotionDAL.GetLatestId(prefix);
            int maxNumber = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                string vid = row["VoucherId"].ToString() ?? "0";
                if (vid.Length == 10 && int.TryParse(vid.Substring(8, 2), out int num))
                {
                    if (num > maxNumber) maxNumber = num;
                }
            }

            // Increment and format with leading zeros
            int nextNumber = maxNumber + 1;
            string numberPart = nextNumber.ToString("D2"); //2 ký tự
            string nextId = $"{prefix}{nextNumber:D2}"; //  V240412C02

            return nextId;
        }


        public bool AddVoucher(Voucher v)
        {

            //tránh nhập sai, sử dụng sai
            if (string.IsNullOrEmpty(v.VoucherName))
            {
                throw new Exception("Vui lòng nhập tên Voucher");
            }
            if (v.ApplyAmount < 0 || v.DiscountValue < 0 || v.MaxApply < 0)
            {
                throw new Exception("Tiền không thể âm");
            }
            if ((!v.IsCash && (v.DiscountValue >= 100))
                || (v.DiscountValue <= 0))
            {
                throw new Exception("Số lượng giảm không được vượt hay bằng 100%");
            }
            if (v.IsCash)
            {
                if (v.DiscountValue != v.MaxApply)
                {
                    throw new Exception("Khi giảm tiến, số lượng giảm phải bằng số lượng giảm tối đa");
                }
                if (v.DiscountValue >= v.ApplyAmount || v.MaxApply >= v.ApplyAmount)
                {
                    throw new Exception("Số lượng giảm không được nhiều hơn mức áp dụng");
                }
            }
            else
            {
                if (v.MaxApply >= v.ApplyAmount)
                {
                    throw new Exception("Số lượng giảm không được nhiều hơn mức");
                }
            }

            if (((v.ReleaseDate < DateTime.Today) || (v.ExpireDate < DateTime.Today)))
                throw new Exception("Thời gian áp dụng không thể ở quá khứ");
            if ((v.ReleaseDate > v.ExpireDate))
                throw new Exception("Vui lòng nhập đúng thời gian");

            string id = GenerateVoucherId(v.ReleaseDate, v.IsCash);
            v.VoucherId = id;
            if (promotionDAL.AddVoucher(v))
                return true;
            return false;
        }

        public string EditVoucher(Voucher oldV, Voucher newV)
        {
            //tránh nhập sai, sử dụng sai
            if (string.IsNullOrEmpty(newV.VoucherName))
            {
                throw new Exception("Vui lòng nhập tên Voucher");
            }
            if (newV.ApplyAmount < 0 || newV.DiscountValue < 0 || newV.MaxApply < 0)
            {
                throw new Exception("Tiền không thể âm");
            }
            if ((!newV.IsCash && (newV.DiscountValue >= 100))
                || (newV.DiscountValue <= 0))
            {
                throw new Exception("Số lượng giảm không được vượt hay bằng 100%");
            }
            if (newV.IsCash)
            {
                if (newV.DiscountValue != newV.MaxApply)
                {
                    throw new Exception("Khi giảm tiến, số lượng giảm phải bằng số lượng giảm tối đa");
                }
                if (newV.DiscountValue >= newV.ApplyAmount || newV.MaxApply >= newV.ApplyAmount)
                {
                    throw new Exception("Số lượng giảm không được nhiều hơn mức áp dụng");
                }
            }
            else
            {
                if (newV.MaxApply >= newV.ApplyAmount)
                {
                    throw new Exception("Số lượng giảm không được nhiều hơn mức");
                }
            }
            if (((newV.ReleaseDate < DateTime.Today) || (newV.ExpireDate < DateTime.Today)))
                throw new Exception("Thời gian áp dụng không thể ở quá khứ");
            if ((newV.ReleaseDate > newV.ExpireDate))
                throw new Exception("Vui lòng nhập đúng thời gian");



            //nếu mà chưa ra mắt i.e isActive = 0 và chưa tới lúc xài thì được đổi
            if (oldV.ReleaseDate > DateTime.Today && !oldV.IsDeactivated)
            {
                string newId = GenerateVoucherId(newV.ReleaseDate, newV.IsCash);
                newV.VoucherId = newId;
                if (!oldV.IsDebuted)//nếu mà chưa ra mắt thì cho sửa
                    try
                    {
                        promotionDAL.EditVoucher(newV, oldV.VoucherId);
                        return "Đã sửa voucher chưa ra mắt";
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                else 
                {                    
                    try
                    {
                        promotionDAL.DeactivateVoucher(oldV.VoucherId);
                        promotionDAL.AddVoucher(newV);
                        return "Đã vô hiệu hóa voucher đã ra mắt và tạo mới";
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
            }
            if (oldV.ExpireDate >= DateTime.Today && !oldV.IsDeactivated)//nếu mà chưa hết hạn 
            {
                string newId = GenerateVoucherId(newV.ReleaseDate, newV.IsCash);
                newV.VoucherId = newId;
                if (oldV.IsDebuted)//nếu mà đã ra mắt thì thu về luôn giống trên
                {
                    try
                    {
                        promotionDAL.DeactivateVoucher(oldV.VoucherId);
                        promotionDAL.AddVoucher(newV);
                        return "Đã vô hiệu hóa voucher đã ra mắt và tạo mới";
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
                else//nếu mà chưa ra mắt thì cho sửa
                    try
                    {
                        promotionDAL.EditVoucher(newV, oldV.VoucherId);
                        return "Đã sửa voucher chưa ra mắt";
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
            }
            else 
            {
                Voucher voucher = promotionDAL.GetVoucherList().FirstOrDefault(voucher => !voucher.IsActive && voucher.VoucherId == oldV.VoucherId);
                string id = GenerateVoucherId(newV.ReleaseDate, newV.IsCash);
                newV.VoucherId = id;
                try
                {
                    promotionDAL.AddVoucher(newV);
                    return "Đã tạo mới voucher dựa trên voucher cũ";
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

        }

        public void deactivateVoucher(string voucherId)
        {
            Voucher voucher = promotionDAL.GetVoucherList().FirstOrDefault(v => v.VoucherId == voucherId);
            if (voucher.IsDeactivated)
            {
                throw new Exception("voucher vốn dĩ đã được thu hồi");
            }
            if (voucher.ReleaseDate < DateTime.Today && voucher.ExpireDate < DateTime.Today)
            {
                throw new Exception("voucher đã hết hạn");
            }
            if (voucher == null)
            {
                throw new Exception("voucher không được tìm thấy");
            }
            else
            {
                promotionDAL.DeactivateVoucher(voucherId);
            }
        }

        public void activateVoucher(string voucherId)
        {
            Voucher voucher = promotionDAL.GetVoucherList().FirstOrDefault(v => v.VoucherId == voucherId);
            if (voucher.IsDebuted)
            {
                throw new Exception("voucher vốn dĩ đã được ra mắt");
            }
            if (voucher.IsDeactivated)
            {
                throw new Exception("voucher đã bị thu hồi và không thể ra mắt nữa");
            }
            if (voucher.ReleaseDate < DateTime.Today && voucher.ExpireDate < DateTime.Today)
            {
                throw new Exception("voucher đã hết hạn");
            }
            if (voucher == null)
            {
                throw new Exception("voucher không được tìm thấy");
            }
            else
            {
                promotionDAL.ActivateVoucher(voucherId);
            }
        }
    }
}
