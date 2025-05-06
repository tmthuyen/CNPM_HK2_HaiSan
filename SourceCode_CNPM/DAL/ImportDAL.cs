using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using DTO;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DAL
{
    public class ImportDAL
    {
        private ImportDetailDAL importDetailDAL = new ImportDetailDAL();

        // Lấy danh sách tất cả nhập hàng (bao gồm chi tiết)
        public List<Import> GetAll()
        {
            string query = "SELECT * FROM Import";
            DataTable dt = Connection.ExecuteQuery(query);
            List<Import> imports = new List<Import>();

            foreach (DataRow row in dt.Rows)
            {
                string importId = row["ImportId"].ToString().Trim();
                string supId = row["SupplierId"].ToString().Trim();
                DateTime importDate = Convert.ToDateTime(row["ImportDate"]);
                int numOfPro = Convert.ToInt32(row["NumOfProducts"]);

                List<ImportDetail> importDetails = importDetailDAL.Search(row["ImportId"].ToString(), null, null);

                imports.Add(new Import(importId, supId, importDate, numOfPro, importDetails));
            }

            return imports;
        }

        // Thêm nhập hàng mới (và chi tiết)
        public bool Add(Import import)
        {
            string query = @"INSERT INTO Import (ImportId, SupplierId, ImportDate, NumOfProducts)
                             VALUES (@Id, @SupId, @ImportDate, @NumOfProducts)";

            SqlParameter[] parameters = {
                new SqlParameter("@Id", import.ImportId),
                new SqlParameter("@SupId", import.SupplierId),
                new SqlParameter("@ImportDate", import.ImportDate),
                new SqlParameter("@NumOfProducts", import.NumOfProducts)
            };

            bool result = Connection.ExecuteNonQuery(query, parameters) > 0;

            if (!result)
                return false;

            // Thêm từng chi tiết nhập hàng
            foreach (var detail in import.ImportDetails)
            {
                importDetailDAL.Add(detail);
            }

            return true;
        }

        // Tìm nhập hàng theo mã (bao gồm chi tiết)
        public Import GetById(string importId)
        {
            string query = "SELECT * FROM Import WHERE ImportId = @ImportId";
            SqlParameter param = new SqlParameter("@ImportId", importId);
            DataTable dt = Connection.ExecuteQuery(query, param);

            if (dt.Rows.Count == 0)
                return null;

            DataRow row = dt.Rows[0];
            string supId = row["SupplierId"].ToString().Trim();
            DateTime importDate = Convert.ToDateTime(row["ImportDate"]);
            int numOfPro = Convert.ToInt32(row["NumOfProducts"]);


            // Lấy chi tiết nhập hàng
            List<ImportDetail> importDetails = importDetailDAL.Search(row["ImportId"].ToString(), null, null);


            return new Import(importId,supId, importDate, numOfPro, importDetails);
        }

        public int GetMinPurchasePro(string proId)
        { 
            string sql = @"SELECT MIN(PurchasePrice) FROM ImportDetail where ProductId = @proId";

            return (int)Connection.ExecuteScalar(sql, new SqlParameter("@proId", proId));
        }

            public string CreateNewId()
        {
            string sql = "Select Top 1 ImportId from Import order by ImportId DESC";

            DataTable dt = Connection.ExecuteQuery(sql);

            if (dt.Rows.Count > 0)
            {
                string lastId = dt.Rows[0]["ImportId"].ToString().Trim();  //  
                string numberPart = lastId.Substring("IMP".Length);               // "007"
                int number = int.Parse(numberPart) + 1;                // 8
                return "IMP" + number.ToString("D5");                  //  
            }
            else
            {
                return "IMP" + "00001"; // Trường hợp chưa có dữ liệu
            }

        }


        /// báo cáo thông kê
        public DataTable GetNumImp_TotalImp(DateTime fromDate, DateTime toDate)
        {  
            string sql = @"SELECT 
                    COUNT(DISTINCT id.ImportId) AS NumImports,
                    ISNULL(SUM(id.Quantity * id.PurchasePrice), 0) AS TotalImport
                        FROM Import AS i
                        JOIN ImportDetail AS id ON id.ImportId = i.ImportId
                        WHERE i.ImportDate >= @fromDate AND i.ImportDate < @toDate"; 

            return Connection.ExecuteQuery(sql, new SqlParameter[]
                            {
                                new SqlParameter("@fromDate", fromDate),
                                new SqlParameter("@toDate", toDate)
                            });
        }


        // lay danh sách san pham sap het hạn hoac sap hêt so luong
        public DataTable GetProductNearExpire()
        {
            string sql = @"
                SELECT 
                    p.ProductId,
                    p.ProductName,
                    p.RetailPrice,
                    SUM(id.Remaining) AS [Tồn kho],
                    MAX(id.Expire) AS [Ngày hết hạn gần nhất]
                FROM ImportDetail id
                JOIN Products p ON p.ProductId = id.ProductId
                GROUP BY 
                    p.ProductId, 
                    p.ProductName,
                    p.RetailPrice
                HAVING 
                    MAX(CAST(id.Expire AS DATE)) <= CAST(GETDATE() + 5 AS DATE)
                    OR SUM(id.Remaining) < 5";


            return Connection.ExecuteQuery(sql);
        }

    }
}
