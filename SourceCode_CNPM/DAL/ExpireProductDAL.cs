using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using DTO;
using System.Collections;

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

        // tao ma het han moi
        public string CreateNewId()
        {
            string query = "SELECT TOP 1 ExpireProductId FROM ExpireProduct ORDER BY ExpireProductId DESC";
            DataTable dt = Connection.ExecuteQuery(query);

            if (dt.Rows.Count > 0)
            {
                string lastId = dt.Rows[0]["ExpireProductId"].ToString();  // VD: "Sup007"
                string numberPart = lastId.Substring(5);               // "007"
                int number = int.Parse(numberPart) + 1;                // 8
                return "Expir" + number.ToString("D5");                  // "Sup008"
            }
            else
            {
                return "Sup001"; // Trường hợp chưa có dữ liệu
            }
        }

        private string CreateNextId(string curId, int idx)
        {

            string numberPart = curId.Substring(5);
            int number = int.Parse(numberPart) + idx;
            return "Expir" + number.ToString("D5");
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

        public int UpdateInventory()
        {
            string sql = @"SELECT id.* FROM ImportDetail AS id WHERE Remaining > 0 
                AND DATEADD(DAY, -1, CAST(Expire AS DATE)) <= CAST(GETDATE() AS DATE)";
            string newIdCur = CreateNewId();

            DataTable dt = Connection.ExecuteQuery(sql);
            
            List<ExpireProduct> l = new List<ExpireProduct>();

            if (dt.Rows.Count > 0)
            {
                int i = 0; 
                foreach (DataRow row in dt.Rows)
                {
                    float remaining = Convert.ToSingle(row["Remaining"]);
                    newIdCur = CreateNextId(newIdCur, i);
                    ExpireProduct exp = new ExpireProduct(
                        newIdCur,
                        row["ProductId"].ToString(),
                        remaining,
                        (int)(remaining * Convert.ToInt32(row["PurchasePrice"])),
                        DateTime.Now
                    );
                    i++;

                    Add( exp );
                }

                // reset bang import detail cột remaining
                string sqlReset = @"UPDATE ImportDetail SET Remaining = 0 
                    WHERE Remaining > 0 AND DATEADD(DAY, -1, CAST(Expire AS DATE)) <= CAST(GETDATE() AS DATE)
                ";

                return Connection.ExecuteNonQuery(sqlReset);
            }

            return 0;
        }
        public List<ExpireProduct> Search(string proId, string proName)
        {
            string query = @"SELECT exp.* 
                        FROM ExpireProduct AS exp
                        JOIN Products as p ON p.ProductId = exp.ProductId
                        WHERE exp.ProductId = @proId OR p.ProductName LIKE @proName 
                ";

            SqlParameter[] param = {
                new SqlParameter("@proId", proId),
                new SqlParameter("@proName", "%" + proName + "%")
            };

            DataTable dt = Connection.ExecuteQuery(query, param);
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



        // báo cáo thong kê
        public int GetTotalLoss(DateTime fromDate, DateTime toDate)
        {
            //DataTable dt = new DataTable();
            //dt.Columns.Add("TotalLoss", typeof(decimal)); // Đặt đúng kiểu
            toDate  = toDate.AddDays(1);

            string sql = @"SELECT ISNULL(SUM(TotalLoss), 0) 
                FROM ExpireProduct
                WHERE ExpiredDate >= @fromDate AND ExpiredDate < @toDate";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@fromDate", fromDate.Date),
                new SqlParameter("@toDate", toDate.Date)
            };

            int totalLoss = (int)Connection.ExecuteScalar(sql, parameters); // Dùng decimal luôn

            return totalLoss;
            //dt.Rows.Add(totalLoss);

            //return dt;
        }

    }
}
