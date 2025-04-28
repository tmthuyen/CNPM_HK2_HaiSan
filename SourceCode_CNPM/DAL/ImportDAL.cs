using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using DTO;

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
                DateTime importDate = Convert.ToDateTime(row["ImportDate"]);
                int numOfPro = Convert.ToInt32(row["NumOfProducts"]);

                List<ImportDetail> importDetails = importDetailDAL.Search(row["ImportId"].ToString(), null, null);

                imports.Add(new Import(importId, importDate, numOfPro, importDetails));
            }

            return imports;
        }

        // Thêm nhập hàng mới (và chi tiết)
        public bool Add(Import import)
        {
            string query = @"INSERT INTO Import (ImportId, ImportDate, NumOfProducts)
                             VALUES (@Id, @ImportDate, @NumOfProducts)";

            SqlParameter[] parameters = {
                new SqlParameter("@Id", import.ImportId),
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
            DateTime importDate = Convert.ToDateTime(row["ImportDate"]);
            int numOfPro = Convert.ToInt32(row["NumOfProducts"]);


            // Lấy chi tiết nhập hàng
            List<ImportDetail> importDetails = importDetailDAL.Search(row["ImportId"].ToString(), null, null);


            return new Import(importId, importDate, numOfPro, importDetails);
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
    }
}
