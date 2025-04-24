using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using DTO;

namespace DAL
{
    public class ImportDetailDAL
    {
        // Lấy tất cả chi tiết nhập
        public List<ImportDetail> GetAll()
        {
            string query = "SELECT * FROM ImportDetail";
            DataTable dt = Connection.ExecuteQuery(query);
            List<ImportDetail> importDetails = new List<ImportDetail>();

            foreach (DataRow row in dt.Rows)
            {
                importDetails.Add(new ImportDetail(
                    row["ImportId"].ToString(),
                    row["ProductId"].ToString(),
                    Convert.ToSingle(row["Quantity"]),
                    Convert.ToSingle(row["Remaining"]),
                    Convert.ToInt32(row["PurchasePrice"]),
                    Convert.ToDateTime(row["Expire"])
                ));
            }

            return importDetails;
        }

        // Thêm chi tiết nhập mới
        public bool Add(ImportDetail importDetail)
        {
            string query = @"INSERT INTO ImportDetail (ImportId, ProductId, Quantity, Remaining, PurchasePrice, Expire)
                             VALUES (@ImportId, @ProductId, @Quantity, @Remaining, @PurchasePrice, @Expire)";

            SqlParameter[] parameters = {
                new SqlParameter("@ImportId", importDetail.ImportId),
                new SqlParameter("@ProductId", importDetail.ProductId),
                new SqlParameter("@Quantity", importDetail.Quantity),
                new SqlParameter("@Remaining", importDetail.Remaining),
                new SqlParameter("@PurchasePrice", importDetail.PurchasePrice),
                new SqlParameter("@Expire", importDetail.Expire)
            };

            return Connection.ExecuteNonQuery(query, parameters) > 0;
        }

        // Tìm chi tiết nhập theo mã nhập
        public List<ImportDetail> GetByImportId(string importId)
        {
            string query = "SELECT * FROM ImportDetail WHERE ImportId = @ImportId";
            SqlParameter param = new SqlParameter("@ImportId", importId);
            DataTable dt = Connection.ExecuteQuery(query, param);

            List<ImportDetail> importDetails = new List<ImportDetail>();

            foreach (DataRow row in dt.Rows)
            {
                importDetails.Add(new ImportDetail(
                    row["ImportId"].ToString(),
                    row["ProductId"].ToString(),
                    Convert.ToSingle(row["Quantity"]),
                    Convert.ToSingle(row["Remaining"]),
                    Convert.ToInt32(row["PurchasePrice"]),
                    Convert.ToDateTime(row["Expire"])
                ));
            }

            return importDetails;
        }

        // Cập nhật số lượng và remaining
        public bool UpdateQuantityAndRemaining(string importId, string productId, float quantity, float remaining)
        {
            string query = @"UPDATE ImportDetail 
                             SET Quantity = @Quantity, Remaining = @Remaining 
                             WHERE ImportId = @ImportId AND ProductId = @ProductId";

            SqlParameter[] parameters = {
                new SqlParameter("@Quantity", quantity),
                new SqlParameter("@Remaining", remaining),
                new SqlParameter("@ImportId", importId),
                new SqlParameter("@ProductId", productId)
            };

            return Connection.ExecuteNonQuery(query, parameters) > 0;
        }

        // Tìm kiếm theo mã nhập, mã sản phẩm hoặc hạn sử dụng
        public List<ImportDetail> Search(string importId, string productId, DateTime? expireBefore)
        {
            string query = "SELECT * FROM ImportDetail WHERE 1=1";
            List<SqlParameter> parameters = new List<SqlParameter>();

            if (!string.IsNullOrWhiteSpace(importId))
            {
                query += " AND ImportId = @ImportId";
                parameters.Add(new SqlParameter("@ImportId", importId));
            }

            if (!string.IsNullOrWhiteSpace(productId))
            {
                query += " AND ProductId = @ProductId";
                parameters.Add(new SqlParameter("@ProductId", productId));
            }

            if (expireBefore.HasValue)
            {
                query += " AND Expire <= @ExpireBefore";
                parameters.Add(new SqlParameter("@ExpireBefore", expireBefore.Value));
            }

            DataTable dt = Connection.ExecuteQuery(query, parameters.ToArray());

            List<ImportDetail> results = new List<ImportDetail>();

            foreach (DataRow row in dt.Rows)
            {
                results.Add(new ImportDetail(
                    row["ImportId"].ToString(),
                    row["ProductId"].ToString(),
                    Convert.ToSingle(row["Quantity"]),
                    Convert.ToSingle(row["Remaining"]),
                    Convert.ToInt32(row["PurchasePrice"]),
                    Convert.ToDateTime(row["Expire"])
                ));
            }

            return results;
        }
        //cập nhật số lượng sản phẩm cho lô hàng
        public void UpdateImportDetail(string productId, string importId, decimal remaining)
        {
            string sql = "UPDATE ImportDetail SET Remaining = @Remaining WHERE ProductId= @ProductId AND ImportId = @ImportId";

            try
            {
                SqlParameter[] param =
                        {
                            new SqlParameter("@Remaining", remaining),
                            new SqlParameter("@ProductId", productId),
                            new SqlParameter("@ImportId", importId),
                        };
                Connection.ExecuteNonQuery(sql, param);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating import detail for ProductId={productId}, ImportId={importId}: {ex.Message}");
            }
        }
    }
}
