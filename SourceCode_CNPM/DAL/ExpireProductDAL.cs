using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using DTO;

namespace DAL
{
    public class ExpireProductDAL
    {
        // Lấy danh sách sản phẩm hư hỏng
        public List<ExpireProduct> GetAll()
        {
            string query = "SELECT * FROM ExpireProduct";
            DataTable dt = Connection.ExecuteQuery(query);
            List<ExpireProduct> list = new List<ExpireProduct>();

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new ExpireProduct(
                    row["ExpireProductId"].ToString(),
                    row["ProductId"].ToString(),
                    Convert.ToSingle(row["Quantity"]),
                    Convert.ToInt32(row["TotalLoss"]),
                    Convert.ToDateTime(row["ExpiredDate"])
                ));
            }

            return list;
        }

        // Thêm mới sản phẩm hư hỏng
        public bool Add(ExpireProduct expired)
        {
            string query = @"INSERT INTO ExpireProduct 
                             (ExpireProductId, ProductId, Quantity, TotalLoss, ExpiredDate)
                             VALUES (@Id, @ProductId, @Quantity, @TotalLoss, @ExpiredDate)";

            SqlParameter[] parameters = {
                new SqlParameter("@Id", expired.ExpireProductId),
                new SqlParameter("@ProductId", expired.ProductId),
                new SqlParameter("@Quantity", expired.Quantity),
                new SqlParameter("@TotalLoss", expired.TotalLoss),
                new SqlParameter("@ExpiredDate", expired.ExpiredDate)
            };

            return Connection.ExecuteNonQuery(query, parameters) > 0;
        }

        // Cập nhật sản phẩm hư hỏng
        public bool Update(ExpireProduct expired)
        {
            string query = @"UPDATE ExpireProduct SET 
                                ProductId = @ProductId,
                                Quantity = @Quantity,
                                TotalLoss = @TotalLoss,
                                ExpiredDate = @ExpiredDate
                             WHERE ExpireProductId = @Id";

            SqlParameter[] parameters = {
                new SqlParameter("@Id", expired.ExpireProductId),
                new SqlParameter("@ProductId", expired.ProductId),
                new SqlParameter("@Quantity", expired.Quantity),
                new SqlParameter("@TotalLoss", expired.TotalLoss),
                new SqlParameter("@ExpiredDate", expired.ExpiredDate)
            };

            return Connection.ExecuteNonQuery(query, parameters) > 0;
        }
    }
}
