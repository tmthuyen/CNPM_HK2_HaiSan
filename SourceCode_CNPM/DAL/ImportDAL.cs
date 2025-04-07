using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using DTO;

namespace DAL
{
    public class ImportDAL
    {
        // Lấy danh sách tất cả nhập hàng
        public List<Import> GetAll()
        {
            string query = "SELECT * FROM Import";
            DataTable dt = Connection.ExecuteQuery(query);
            List<Import> imports = new List<Import>();

            foreach (DataRow row in dt.Rows)
            {
                imports.Add(new Import(
                    row["ImportId"].ToString(),
                    Convert.ToDateTime(row["ImportDate"]),
                    Convert.ToInt32(row["TotalCost"])
                ));
            }

            return imports;
        }

        // Thêm nhập hàng mới
        public bool Add(Import import)
        {
            string query = @"INSERT INTO Import (ImportId, ImportDate, TotalCost)
                             VALUES (@Id, @ImportDate, @TotalCost)";

            SqlParameter[] parameters = {
                new SqlParameter("@Id", import.ImportId),
                new SqlParameter("@ImportDate", import.ImportDate),
                new SqlParameter("@TotalCost", import.TotalCost)
            };

            return Connection.ExecuteNonQuery(query, parameters) > 0;
        }


        // Tìm nhập hàng theo mã nhập
        public Import GetById(string importId)
        {
            string query = "SELECT * FROM Import WHERE ImportId = @ImportId";
            SqlParameter param = new SqlParameter("@ImportId", importId);

            DataTable dt = Connection.ExecuteQuery(query, param);

            if (dt.Rows.Count == 0)
                return null;

            DataRow row = dt.Rows[0];

            return new Import(
                row["ImportId"].ToString(),
                Convert.ToDateTime(row["ImportDate"]),
                Convert.ToInt32(row["TotalCost"])
            );
        }
    }
}
