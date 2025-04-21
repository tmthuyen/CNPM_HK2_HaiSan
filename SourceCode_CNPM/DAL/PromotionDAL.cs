using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using DTO;
using Microsoft.Data.SqlClient;

namespace DAL
{
    public class PromotionDAL
    {
        public List<Voucher> GetVoucherList()
        {
            string query = "SELECT * FROM Voucher";

            DataTable dt = Connection.ExecuteQuery(query);
            List<Voucher> vouchers = new List<Voucher>();

            foreach (DataRow row in dt.Rows)
            {
                Voucher v = new Voucher
                {
                    VoucherId = row["VoucherId"].ToString(),
                    VoucherName = row["VoucherName"].ToString(),
                    ReleaseDate = Convert.ToDateTime(row["ReleaseDate"]),
                    ExpireDate = Convert.ToDateTime(row["Expire"]),
                    ApplyAmount = Convert.ToInt32(row["ApplyAmount"]),
                    MaxApply = Convert.ToInt32(row["MaxApply"]),
                    DiscountValue = Convert.ToInt32(row["DiscountValue"]),
                    IsCash = Convert.ToBoolean(row["IsCash"]),
                    IsDebuted = Convert.ToInt32(row["IsDebuted"]) == 1,
                    IsDeactivated = Convert.ToInt32(row["IsDeactivated"]) == 1,
                    IsActive = Convert.ToInt32(row["IsActive"]) == 1
                };

                vouchers.Add(v);
            }

            return vouchers;
        }
        public DataTable GetVoucherDataTable()
        {
            return DataTableHelper.ToDataTable(GetVoucherList());
        }
        public bool AddVoucher(Voucher v)
        {
            string query = @"INSERT INTO Voucher (VoucherId, VoucherName, ReleaseDate, Expire, ApplyAmount, MaxApply, DiscountValue, IsCash)
                     VALUES (@VoucherId, @VoucherName, @ReleaseDate, @Expire, @ApplyAmount, @MaxApply, @DiscountValue, @IsCash)";

            SqlParameter[] parameters = {
                new SqlParameter("@VoucherId", v.VoucherId),
                new SqlParameter("@VoucherName", v.VoucherName),
                new SqlParameter("@ReleaseDate", v.ReleaseDate),
                new SqlParameter("@Expire", v.ExpireDate),
                new SqlParameter("@ApplyAmount", v.ApplyAmount),
                new SqlParameter("@MaxApply", v.MaxApply),
                new SqlParameter("@DiscountValue", v.DiscountValue),
                new SqlParameter("@IsCash", v.IsCash),
            };

            try
            {
                Connection.ExecuteNonQuery(query, parameters);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error inserting voucher: " + ex.Message);
            }
        }

        public void EditVoucher(Voucher v, string oldId)
        {
            string sql = @"UPDATE Voucher 
                   SET VoucherId = @VoucherId,
                       VoucherName = @VoucherName,
                       ReleaseDate = @ReleaseDate,
                       Expire = @Expire,
                       ApplyAmount = @ApplyAmount,
                       MaxApply = @MaxApply,
                       DiscountValue = @DiscountValue,
                       IsCash = @IsCash
                   WHERE VoucherId = @OldVoucherId";

            SqlParameter[] parameters = {
                new SqlParameter("@VoucherId", v.VoucherId),
                new SqlParameter("@VoucherName", v.VoucherName),
                new SqlParameter("@ReleaseDate", v.ReleaseDate),
                new SqlParameter("@Expire", v.ExpireDate),
                new SqlParameter("@ApplyAmount", v.ApplyAmount),
                new SqlParameter("@MaxApply", v.MaxApply),
                new SqlParameter("@DiscountValue", v.DiscountValue),
                new SqlParameter("@IsCash", v.IsCash),
                new SqlParameter("@OldVoucherId", oldId)
            };

            Connection.ExecuteNonQuery(sql, parameters);
        }

        public DataTable GetLatestId(string idPrefix)
        {
            string query = @"SELECT VoucherId FROM Voucher 
                            WHERE VoucherId LIKE @Prefix + '%'";
            SqlParameter[] parameters = {
                new SqlParameter("@Prefix", idPrefix)
            };
            DataTable results = Connection.ExecuteQuery(query, parameters); // List<DataRow> or similar

            return results;
        }
        public void DeactivateVoucher(string voucherId)
        {
            string sql = @"UPDATE Voucher  
               SET IsDeactivated = 1 
               WHERE VoucherId = @VoucherId";

            SqlParameter[] parameters = {
                new SqlParameter("@VoucherId", voucherId)
            };

            Connection.ExecuteNonQuery(sql, parameters);
        }
        public void ActivateVoucher(string voucherId)
        {
            string sql = @"UPDATE Voucher  
               SET IsDebuted = 1
               WHERE VoucherId = @VoucherId";

            SqlParameter[] parameters = {
                new SqlParameter("@VoucherId", voucherId)
            };

            Connection.ExecuteNonQuery(sql, parameters);
        }
    }
}