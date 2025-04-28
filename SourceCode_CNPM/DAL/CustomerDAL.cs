using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using DTO;

namespace DAL
{
    public class CustomerDAL
    {
        private string table = "Customer";

        // Lấy danh sách tất cả khách hàng
        public List<Customer> GetAll()
        {
            string query = $"SELECT * FROM {table}";
            DataTable dt = Connection.ExecuteQuery(query);
            List<Customer> customers = new List<Customer>();

            foreach (DataRow row in dt.Rows)
            {
                customers.Add(new Customer(
                    row["CustomerId"].ToString(),
                    row["CustomerName"].ToString(),
                    row["Phone"].ToString(),
                    Convert.ToInt32(row["LoyaltyPoint"])
                ));
            }

            return customers;
        }

        // Thêm khách hàng mới
        public bool Add(Customer customer)
        {
            string query = $"INSERT INTO {table} (CustomerId, Phone, CustomerName, LoyaltyPoint) VALUES (@Id, @Phone, @Name, @LoyaltyPoint)";

            SqlParameter[] parameters = {
                new SqlParameter("@Id", customer.CustomerId),
                new SqlParameter("@Phone", customer.Phone),
                new SqlParameter("@Name", customer.CustomerName),
                new SqlParameter("@LoyaltyPoint", customer.LoyaltyPoint)
            };

            return Connection.ExecuteNonQuery(query, parameters) > 0;
        }

        // Cập nhật thông tin khách hàng
        public bool Update(Customer customer)
        {
            string query = $"UPDATE {table} SET Phone = @Phone, CustomerName = @Name, LoyaltyPoint = @LoyaltyPoint WHERE CustomerId = @Id";

            SqlParameter[] parameters = {
                new SqlParameter("@Id", customer.CustomerId),
                new SqlParameter("@Phone", customer.Phone),
                new SqlParameter("@Name", customer.CustomerName),
                new SqlParameter("@LoyaltyPoint", customer.LoyaltyPoint)
            };

            return Connection.ExecuteNonQuery(query, parameters) > 0;
        }

        // Xóa khách hàng
        public bool Delete(string customerId)
        {
            string query = "DELETE FROM Customers WHERE CustomerId = @Id";
            SqlParameter param = new SqlParameter("@Id", customerId);
            return Connection.ExecuteNonQuery(query, param) > 0;
        }

        // Tim khach hang theo id, ten, so dien thoai
        public List<Customer> Search(string customerId = "", string phone = "", string name = "")
        {
            List<Customer> customers = new List<Customer>();
            string query = "SELECT * FROM Customer WHERE 1=1"; // Điều kiện mặc định

            // Khởi tạo danh sách các tham số cho query
            List<SqlParameter> parameters = new List<SqlParameter>();

            // Thêm điều kiện và tham số vào query một cách linh hoạt
            if (!string.IsNullOrEmpty(customerId))
            {
                query += " AND CustomerId = @CustomerId";
                parameters.Add(new SqlParameter("@CustomerId", customerId));
            }

            if (!string.IsNullOrEmpty(phone))
            {
                query += " AND Phone = @Phone";
                parameters.Add(new SqlParameter("@Phone", phone));
            }

            if (!string.IsNullOrEmpty(name))
            {
                query += " AND CustomerName LIKE @Name";
                parameters.Add(new SqlParameter("@Name", "%" + name + "%"));
            }

            query += " Order By CustomerId ASC";

            // Thực thi truy vấn và lấy dữ liệu
            DataTable dt = Connection.ExecuteQuery(query, parameters.ToArray());

            // Duyệt qua các dòng dữ liệu và thêm vào danh sách customers
            foreach (DataRow row in dt.Rows)
            {
                customers.Add(new Customer(
                    row["CustomerId"].ToString(),
                    row["CustomerName"].ToString(),
                    row["Phone"].ToString(),
                    Convert.ToInt32(row["LoyaltyPoint"])
                ));
            }

            return customers;
        }


        public bool CheckExist(string id, string phone, string name)
        {
            return Search("", phone, "")[0] != null;
        }


    }
}
