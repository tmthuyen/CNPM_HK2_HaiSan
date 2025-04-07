using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using DTO;

namespace DAL
{
    public class SupplierDAL
    {
        // Lấy danh sách tất cả nhà cung cấp
        public List<Supplier> GetAll()
        {
            string query = "SELECT * FROM Supplier";
            DataTable dt = Connection.ExecuteQuery(query);
            List<Supplier> suppliers = new List<Supplier>();

            foreach (DataRow row in dt.Rows)
            {
                suppliers.Add(new Supplier(
                    row["SupplierId"].ToString(),
                    row["SupplierName"].ToString(),
                    row["Phone"].ToString(),
                    row["Email"].ToString(),
                    row["Address"].ToString()
                ));
            }

            return suppliers;
        }

        // Thêm nhà cung cấp mới
        public bool Add(Supplier supplier)
        {
            string query = @"INSERT INTO Supplier (SupplierId, SupplierName, Phone, Email, Address)
                             VALUES (@Id, @Name, @Phone, @Email, @Address)";

            SqlParameter[] parameters = {
                new SqlParameter("@Id", supplier.SupplierId),
                new SqlParameter("@Name", supplier.SupplierName),
                new SqlParameter("@Phone", supplier.Phone),
                new SqlParameter("@Email", supplier.Email),
                new SqlParameter("@Address", supplier.Address)
            };

            return Connection.ExecuteNonQuery(query, parameters) > 0;
        }

        // Cập nhật thông tin nhà cung cấp
        public bool Update(Supplier supplier)
        {
            string query = @"UPDATE Supplier 
                             SET SupplierName = @Name, Phone = @Phone, Email = @Email, Address = @Address
                             WHERE SupplierId = @Id";

            SqlParameter[] parameters = {
                new SqlParameter("@Id", supplier.SupplierId),
                new SqlParameter("@Name", supplier.SupplierName),
                new SqlParameter("@Phone", supplier.Phone),
                new SqlParameter("@Email", supplier.Email),
                new SqlParameter("@Address", supplier.Address)
            };

            return Connection.ExecuteNonQuery(query, parameters) > 0;
        }

        // Xóa nhà cung cấp
        public bool Delete(string supplierId)
        {
            string query = "DELETE FROM Supplier WHERE SupplierId = @Id";
            SqlParameter param = new SqlParameter("@Id", supplierId);
            return Connection.ExecuteNonQuery(query, param) > 0;
        }

        // Tìm nhà cung cấp theo mã nhà cung cấp
        public Supplier GetById(string supplierId)
        {
            string query = "SELECT * FROM Supplier WHERE SupplierId = @SupplierId";
            SqlParameter param = new SqlParameter("@SupplierId", supplierId);

            DataTable dt = Connection.ExecuteQuery(query, param);

            if (dt.Rows.Count == 0)
                return null;

            DataRow row = dt.Rows[0];

            return new Supplier(
                row["SupplierId"].ToString(),
                row["SupplierName"].ToString(),
                row["Phone"].ToString(),
                row["Email"].ToString(),
                row["Address"].ToString()
            );
        }

    }
}
