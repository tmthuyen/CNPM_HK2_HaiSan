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
    public static class PromotionDAL
    {
        public static List<Voucher> GetVoucherList()
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
                    IsActive = Convert.ToInt32(row["IsCurrentlyActive"]) == 1
                };

                vouchers.Add(v);
            }

            return vouchers;
        }

        public static void addVoucher(string id, string name, int apply, int discount, int max, bool isCash, DateTime from, DateTime to)
        {
            string query = @"INSERT INTO Voucher (VoucherId, VoucherName, ReleaseDate, Expire, ApplyAmount, MaxApply, DiscountValue, IsCash)
                     VALUES (@VoucherId, @VoucherName, @ReleaseDate, @Expire, @ApplyAmount, @MaxApply, @DiscountValue, @IsCash)";

            SqlParameter[] parameters = {
                new SqlParameter("@VoucherId", id),
                new SqlParameter("@VoucherName", name),
                new SqlParameter("@ReleaseDate", from),
                new SqlParameter("@Expire", to),
                new SqlParameter("@ApplyAmount", apply),
                new SqlParameter("@MaxApply", max),
                new SqlParameter("@DiscountValue", discount),
                new SqlParameter("@IsCash", isCash)
            };

            Connection.ExecuteNonQuery(query, parameters);
        }

        public static void editVoucher(string id, string name, int apply, int discount, int max, bool isCash, DateTime from, DateTime to)
        {
            string query = @"UPDATE Voucher
                     SET VoucherName = @VoucherName,
                         ReleaseDate = @ReleaseDate,
                         Expire = @Expire,
                         ApplyAmount = @ApplyAmount,
                         MaxApply = @MaxApply,
                         DiscountValue = @DiscountValue,
                         IsCash = @IsCash
                     WHERE VoucherId = @VoucherId";

            SqlParameter[] parameters = {
                new SqlParameter("@VoucherId", id),
                new SqlParameter("@VoucherName", name),
                new SqlParameter("@ReleaseDate", from),
                new SqlParameter("@Expire", to),
                new SqlParameter("@ApplyAmount", apply),
                new SqlParameter("@MaxApply", max),
                new SqlParameter("@DiscountValue", discount),
                new SqlParameter("@IsCash", isCash)
            };

            Connection.ExecuteNonQuery(query, parameters);
        }

        public static DataTable getLatestId(string idPrefix)
        {
            string query = @"SELECT VoucherId FROM Voucher 
                            WHERE VoucherId LIKE @Prefix + '%'";
            SqlParameter[] parameters = {
                new SqlParameter("@Prefix", idPrefix)
            };
            DataTable results = Connection.ExecuteQuery(query, parameters); // List<DataRow> or similar

            return results;
        }
        public static void deactivateVoucher(string voucherId)
        {
            string sql = @"UPDATE Voucher  
               SET IsActive = 0 
               WHERE VoucherId = @VoucherId";

            SqlParameter[] parameters = {
                new SqlParameter("@VoucherId", voucherId)
            };

            Connection.ExecuteNonQuery (sql, parameters);
        }

    }
}
