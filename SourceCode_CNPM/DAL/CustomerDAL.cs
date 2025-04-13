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
                    row["Phone"].ToString(),
                    row["CustomerName"].ToString(),
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

        // Tìm khách hàng theo mã hoac so dien thoai khách hàng
        public Customer GetById(string customerId="", string phone="")
        {
            if(customerId == "" && phone == "")
                return null;

            string query = "SELECT * FROM Customers";
            if(customerId != ""){
                query += "CustomerId = @CustomerId";
            }
            if(phone != "")
                query += "Phone = @phone";

            
            SqlParameter param = new SqlParameter("@CustomerId", customerId);

            DataTable dt = Connection.ExecuteQuery(query, param);

            if (dt.Rows.Count == 0)
                return null;

            DataRow row = dt.Rows[0];

            return new Customer(
                row["CustomerId"].ToString(),
                row["CustomerName"].ToString(),
                row["Phone"].ToString(),
                Convert.ToInt32(row["LoyaltyPoint"])
            );
        } 

        // Tìm khách hàng theo tên
        public List<Customer> FindByName(string name)
        {
            List<Customer> customers = new List<Customer>();
            string query = "SELECT * FROM Customers WHERE CustomerName LIKE @Name";
            SqlParameter param = new SqlParameter("@Name", "%" + name + "%");

            DataTable dt = Connection.ExecuteQuery(query, param);

            foreach (DataRow row in dt.Rows)
            {
                customers.Add(new Customer(
                    row["CustomerId"].ToString(),
                    row["Phone"].ToString(),
                    row["CustomerName"].ToString(),
                    Convert.ToInt32(row["LoyaltyPoint"])
                ));
            }

            return customers;
        }
    }
}
