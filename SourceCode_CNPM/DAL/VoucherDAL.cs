using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using DTO;

namespace DAL
{
    public class VoucherDAL
    {
        // Lấy tất cả voucher
        public List<Voucher> GetAll()
        {
            string query = "SELECT * FROM Voucher";
            DataTable dt = Connection.ExecuteQuery(query);
            List<Voucher> list = new List<Voucher>();

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new Voucher(
                    row["VoucherId"].ToString(),
                    row["VoucherName"].ToString(),
                    Convert.ToDateTime(row["ReleaseDate"]),
                    Convert.ToDateTime(row["Expire"]),
                    Convert.ToInt32(row["ApplyAmount"]),
                    Convert.ToInt32(row["MaxApply"]),
                    Convert.ToInt32(row["DiscountValue"]),
                    Convert.ToBoolean(row["IsCash"])
                ));
            }

            return list;
        }

        // Thêm voucher mới
        public bool Add(Voucher voucher)
        {
            string query = @"INSERT INTO Voucher 
                             (VoucherId, VoucherName, ReleaseDate, Expire, ApplyAmount, MaxApply, DiscountValue, IsCash) 
                             VALUES (@Id, @Name, @ReleaseDate, @Expire, @ApplyAmount, @MaxApply, @DiscountValue, @IsCash)";

            SqlParameter[] parameters = {
                new SqlParameter("@Id", voucher.VoucherId),
                new SqlParameter("@Name", voucher.VoucherName),
                new SqlParameter("@ReleaseDate", voucher.ReleaseDate),
                new SqlParameter("@Expire", voucher.ExpireDate),
                new SqlParameter("@ApplyAmount", voucher.ApplyAmount),
                new SqlParameter("@MaxApply", voucher.MaxApply),
                new SqlParameter("@DiscountValue", voucher.DiscountValue),
                new SqlParameter("@IsCash", voucher.IsCash)
            };

            return Connection.ExecuteNonQuery(query, parameters) > 0;
        }

        // Cập nhật voucher
        public bool Update(Voucher voucher)
        {
            string query = @"UPDATE Voucher SET 
                                VoucherName = @Name,
                                ReleaseDate = @ReleaseDate,
                                Expire = @Expire,
                                ApplyAmount = @ApplyAmount,
                                MaxApply = @MaxApply,
                                DiscountValue = @DiscountValue,
                                IsCash = @IsCash
                             WHERE VoucherId = @Id";

            SqlParameter[] parameters = {
                new SqlParameter("@Id", voucher.VoucherId),
                new SqlParameter("@Name", voucher.VoucherName),
                new SqlParameter("@ReleaseDate", voucher.ReleaseDate),
                new SqlParameter("@Expire", voucher.ExpireDate),
                new SqlParameter("@ApplyAmount", voucher.ApplyAmount),
                new SqlParameter("@MaxApply", voucher.MaxApply),
                new SqlParameter("@DiscountValue", voucher.DiscountValue),
                new SqlParameter("@IsCash", voucher.IsCash)
            };

            return Connection.ExecuteNonQuery(query, parameters) > 0;
        }
    }
}
