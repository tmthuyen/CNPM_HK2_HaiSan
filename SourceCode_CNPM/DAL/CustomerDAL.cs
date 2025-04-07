using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using DTO;

namespace DAL
{
    public class CustomerDAL
    {
        // Lấy danh sách tất cả khách hàng
        public List<Customer> GetAll()
        {
            string query = "SELECT * FROM Customers";
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
            string query = @"INSERT INTO Customers (CustomerId, Phone, CustomerName, LoyaltyPoint)
                             VALUES (@Id, @Phone, @Name, @LoyaltyPoint)";

            SqlParameter[] parameters = {
                new SqlParameter("@Id", customer.CustomerId),
                new SqlParameter("@Phone", customer.CustomerPhone),
                new SqlParameter("@Name", customer.FullName),
                new SqlParameter("@LoyaltyPoint", customer.LoyaltyPoint)
            };

            return Connection.ExecuteNonQuery(query, parameters) > 0;
        }

        // Cập nhật thông tin khách hàng
        public bool Update(Customer customer)
        {
            string query = @"UPDATE Customers 
                             SET Phone = @Phone, CustomerName = @Name, LoyaltyPoint = @LoyaltyPoint
                             WHERE CustomerId = @Id";

            SqlParameter[] parameters = {
                new SqlParameter("@Id", customer.CustomerId),
                new SqlParameter("@Phone", customer.CustomerPhone),
                new SqlParameter("@Name", customer.FullName),
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

        // Tìm khách hàng theo mã khách hàng
        public Customer GetById(string customerId)
        {
            string query = "SELECT * FROM Customers WHERE CustomerId = @CustomerId";
            SqlParameter param = new SqlParameter("@CustomerId", customerId);

            DataTable dt = Connection.ExecuteQuery(query, param);

            if (dt.Rows.Count == 0)
                return null;

            DataRow row = dt.Rows[0];

            return new Customer(
                row["CustomerId"].ToString(),
                row["Phone"].ToString(),
                row["CustomerName"].ToString(),
                Convert.ToInt32(row["LoyaltyPoint"])
            );
        }

        // Tìm khách hàng theo số điện thoại
        public Customer FindByPhone(string phone)
        {
            string query = "SELECT TOP 1 * FROM Customers WHERE Phone = @Phone";
            SqlParameter param = new SqlParameter("@Phone", phone);

            DataTable dt = Connection.ExecuteQuery(query, param);

            if (dt.Rows.Count == 0)
                return null;

            DataRow row = dt.Rows[0];

            return new Customer(
                row["CustomerId"].ToString(),
                row["Phone"].ToString(),
                row["CustomerName"].ToString(),
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
