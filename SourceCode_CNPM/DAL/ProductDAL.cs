using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using DTO;

namespace DAL
{
    public class ProductDAL
    {
        // Lấy danh sách tất cả sản phẩm
        public List<Product> GetAll()
        {
            string query = "SELECT * FROM Products";
            DataTable dt = Connection.ExecuteQuery(query);
            List<Product> products = new List<Product>();

            foreach (DataRow row in dt.Rows)
            {
                products.Add(new Product(
                    row["ProductId"].ToString(), 
                    row["CategoryId"].ToString(),
                    row["ProductName"].ToString(), 
                    Convert.ToInt32(row["RetailPrice"]),
                    Convert.ToDateTime(row["CreatedAt"]),
                    row["Unit"].ToString()
                ));
            }

            return products;
        }

        // tao khoa moi 
        public string CreateNewId(string cateId)
        {
            string sql = "Select Top 1 ProductId from Products where CategoryId = @cateId order by ProductId DESC";

            DataTable dt = Connection.ExecuteQuery(sql, new SqlParameter("@cateId", cateId));

            if (dt.Rows.Count > 0)
            {
                string lastId = dt.Rows[0]["ProductId"].ToString().Trim();  // VD: "Fish0007"
                string numberPart = lastId.Substring(cateId.Length);               // "007"
                int number = int.Parse(numberPart) + 1;                // 8
                return cateId + number.ToString("D4");                  // "Fish0008"
            }
            else
            {
                return  cateId + "0001"; // Trường hợp chưa có dữ liệu
            }

        }


        // Tìm kiếm và sắp xếp theo giá
        public List<Product> SearchProduct(string productId="", string name="", string categoryId="", string filter = "RetailPrice ASC")
        {
            List<Product> products = new List<Product>();
            string query = "SELECT * FROM Products WHERE 1=1";
            List<SqlParameter> parameters = new List<SqlParameter>();

            if (!string.IsNullOrWhiteSpace(productId))
            {
                query += " AND ProductId = @ProductId";
                parameters.Add(new SqlParameter("@ProductId", productId));
            }

            if (!string.IsNullOrWhiteSpace(name))
            {
                query += " AND ProductName LIKE @Name";
                parameters.Add(new SqlParameter("@Name", "%" + name + "%"));
            }

            if (!string.IsNullOrWhiteSpace(categoryId))
            {
                query += " AND CategoryId = @CategoryId";
                parameters.Add(new SqlParameter("@CategoryId", categoryId));
            }

            // Sắp xếp
            query += $" ORDER BY {filter}";

            DataTable dt = Connection.ExecuteQuery(query, parameters.ToArray());

            foreach (DataRow row in dt.Rows)
            {
                products.Add(new Product(
                    row["ProductId"].ToString(), 
                    row["CategoryId"].ToString(),
                    row["ProductName"].ToString(), 
                    Convert.ToInt32(row["RetailPrice"]),
                    Convert.ToDateTime(row["CreatedAt"]),
                    row["Unit"].ToString()
                ));
            }

            return products;
        }


        // Thêm sản phẩm mới
        public bool Add(Product product)
        {
            string query = @"INSERT INTO Products (ProductId, CategoryId, ProductName, 
                                                  RetailPrice, CreatedAt, Unit)
                             VALUES (@Id, @CategoryId, @Name, 
                                     @RetailPrice, @CreatedAt, @Unit)";

            SqlParameter[] parameters = {
                new SqlParameter("@Id", product.ProductId), 
                new SqlParameter("@CategoryId", product.CategoryId),
                new SqlParameter("@Name", product.ProductName), 
                new SqlParameter("@RetailPrice", product.RetailPrice),
                new SqlParameter("@CreatedAt", product.CreatedAt),
                new SqlParameter("@Unit", product.Unit)
            };

            return Connection.ExecuteNonQuery(query, parameters) > 0;
        }

        // Cập nhật thông tin sản phẩm
        public bool Update(Product product)
        {
            string query = @"UPDATE Products 
                             SET CategoryId = @CategoryId, 
                                 ProductName = @Name, 
                                 RetailPrice = @RetailPrice, Unit = @Unit
                             WHERE ProductId = @Id";

            SqlParameter[] parameters = {
                new SqlParameter("@Id", product.ProductId), 
                new SqlParameter("@CategoryId", product.CategoryId),
                new SqlParameter("@Name", product.ProductName), 
                new SqlParameter("@RetailPrice", product.RetailPrice),
                new SqlParameter("@Unit", product.Unit)
            };

            return Connection.ExecuteNonQuery(query, parameters) > 0;
        }

        // Xóa sản phẩm
        public bool Delete(string productId)
        {
            string query = "DELETE FROM Products WHERE ProductId = @Id";
            SqlParameter param = new SqlParameter("@Id", productId);
            return Connection.ExecuteNonQuery(query, param) > 0;
        }

        // kierm tra sp co the xoa hay không: neu ton tai trong import hoac detail
        public bool CanDelete(string proId){
            string sql = "SELECT COUNT(*) FROM ImportDetail WHERE ProductId = @proId";

            if((int)Connection.ExecuteScalar(sql, new SqlParameter("@proId", proId)) > 0)
                return false;
            
            sql = "SELECT COUNT(*) FROM OrderDetail WHERE ProductId = @proId";

            if((int)Connection.ExecuteScalar(sql, new SqlParameter("@proId", proId)) > 0)
                return false;
            
            return true;
        }

        // Tìm sản phẩm theo mã
        public Product GetById(string productId)
        {
            string query = "SELECT * FROM Products WHERE ProductId = @ProductId";
            SqlParameter param = new SqlParameter("@ProductId", productId);

            DataTable dt = Connection.ExecuteQuery(query, param);

            if (dt.Rows.Count == 0)
                return null;

            DataRow row = dt.Rows[0];

            return new Product(
                row["ProductId"].ToString(), 
                row["CategoryId"].ToString(),
                row["ProductName"].ToString(), 
                Convert.ToInt32(row["RetailPrice"]),
                Convert.ToDateTime(row["CreatedAt"]),
                row["Unit"].ToString()
            );
        }

        // Tìm sản phẩm theo tên
        public List<Product> FindByName(string name)
        {
            List<Product> products = new List<Product>();
            string query = "SELECT * FROM Products WHERE ProductName LIKE @Name";
            SqlParameter param = new SqlParameter("@Name", "%" + name + "%");

            DataTable dt = Connection.ExecuteQuery(query, param);

            foreach (DataRow row in dt.Rows)
            {
                products.Add(new Product(
                    row["ProductId"].ToString(), 
                    row["CategoryId"].ToString(),
                    row["ProductName"].ToString(), 
                    Convert.ToInt32(row["RetailPrice"]),
                    Convert.ToDateTime(row["CreatedAt"]),
                    row["Unit"].ToString()
                ));
            }

            return products;
        }

        
    }
}
