using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using DTO;

namespace DAL
{
    public class ImportDetailDAL
    {
        // Lấy danh sách tất cả chi tiết nhập
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
                    Convert.ToInt32(row["Quantity"]),
                    Convert.ToDecimal(row["PurchasePrice"])
                ));
            }

            return importDetails;
        }

        // Thêm chi tiết nhập mới
        public bool Add(ImportDetail importDetail)
        {
            string query = @"INSERT INTO ImportDetail (ImportId, ProductId, Quantity, PurchasePrice)
                             VALUES (@ImportId, @ProductId, @Quantity, @PurchasePrice)";

            SqlParameter[] parameters = {
                new SqlParameter("@ImportId", importDetail.ImportId),
                new SqlParameter("@ProductId", importDetail.ProductId),
                new SqlParameter("@Quantity", importDetail.Quantity),
                new SqlParameter("@PurchasePrice", importDetail.PurchasePrice)
            };

            return Connection.ExecuteNonQuery(query, parameters) > 0;
        }

        // Tìm chi tiết nhập theo mã nhập
        public List<ImportDetail> GetByImportId(string importId)
        {
            List<ImportDetail> importDetails = new List<ImportDetail>();
            string query = "SELECT * FROM ImportDetail WHERE ImportId = @ImportId";
            SqlParameter param = new SqlParameter("@ImportId", importId);

            DataTable dt = Connection.ExecuteQuery(query, param);

            foreach (DataRow row in dt.Rows)
            {
                importDetails.Add(new ImportDetail(
                    row["ImportId"].ToString(),
                    row["ProductId"].ToString(),
                    Convert.ToInt32(row["Quantity"]),
                    Convert.ToDecimal(row["PurchasePrice"])
                ));
            }

            return importDetails;
        }
    }
}
