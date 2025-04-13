using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using DTO;

namespace DAL
{
    public static class ProductDAL
    {
        
        // Lấy danh sách tất cả sản phẩm
        public static List<Product> GetAll()
        {
            string query = "SELECT * FROM Products";
            DataTable dt = Connection.ExecuteQuery(query);
            List<Product> products = new List<Product>();

            foreach (DataRow row in dt.Rows)
            {
                products.Add(new Product(
                    row["ProductId"].ToString(),
                    row["SupplierId"].ToString(),
                    row["CategoryId"].ToString(),
                    row["ProductName"].ToString(),
                    Convert.ToInt32(row["PurchasePrice"]),
                    Convert.ToInt32(row["RetailPrice"]),
                    Convert.ToDateTime(row["CreatedAt"]),
                    Convert.ToDecimal(row["Remaining"]),
                    Convert.ToInt32(row["ShelfLife"]),
                    row["Unit"].ToString()
                ));
            }

            return products;
        }


        // tim kiem sap xep theo gia(mac dinh) tang dan
        public static List<Product> Search(decimal? minPrice, decimal? maxPrice, string categoryId, string name, string sortBy = "RetailPrice", bool ascending = true)  
        {
            List<Product> products = new List<Product>();
            string query = "SELECT * FROM Product WHERE 1=1"; // Bắt đầu với điều kiện luôn đúng

            // Khởi tạo danh sách tham số
            List<SqlParameter> parameters = new List<SqlParameter>();

            // Thêm điều kiện cho khoảng giá
            if (minPrice.HasValue)
            {
                query += " AND RetailPrice >= @MinPrice";
                parameters.Add(new SqlParameter("@MinPrice", minPrice.Value));
            }

            if (maxPrice.HasValue)
            {
                query += " AND RetailPrice <= @MaxPrice";
                parameters.Add(new SqlParameter("@MaxPrice", maxPrice.Value));
            }

            // Thêm điều kiện cho loại sản phẩm
            if (!string.IsNullOrWhiteSpace(categoryId))
            {
                query += " AND CategoryId = @CategoryId";
                parameters.Add(new SqlParameter("@CategoryId", categoryId));
            }

            // Thêm điều kiện cho tên sản phẩm
            if (!string.IsNullOrWhiteSpace(name))
            {
                query += " AND ProductName LIKE @ProductName";
                parameters.Add(new SqlParameter("@ProductName", "%" + name + "%"));
            }

            // Thêm điều kiện sắp xếp
            query += $" ORDER BY {sortBy} {(ascending ? "ASC" : "DESC")}";

            // Thực hiện truy vấn
            DataTable dt = Connection.ExecuteQuery(query, parameters.ToArray());

            // Chuyển đổi DataTable thành danh sách sản phẩm
            foreach (DataRow row in dt.Rows)
            {
                products.Add(new Product(
                    row["ProductId"].ToString(),
                    row["SupplierId"].ToString(),
                    row["CategoryId"].ToString(),
                    row["ProductName"].ToString(),
                    Convert.ToInt32(row["PurchasePrice"]),
                    Convert.ToInt32(row["RetailPrice"]),
                    Convert.ToDateTime(row["CreatedAt"]),
                    Convert.ToDecimal(row["Remaining"]),
                    Convert.ToInt32(row["ShelfLife"]),
                    row["Unit"].ToString()
                ));
            }

            return products;
        }


        // Thêm sản phẩm mới
        public static bool Add(Product product)
        {
            string query = @"INSERT INTO Product (ProductId, SupplierId, CategoryId, ProductName, 
                                                  PurchasePrice, RetailPrice, CreatedAt, 
                                                  Remaining, ShelfLife, Unit)
                             VALUES (@Id, @SupplierId, @CategoryId, @Name, 
                                     @PurchasePrice, @RetailPrice, @CreatedAt, 
                                     @Remaining, @ShelfLife, @Unit)";

            SqlParameter[] parameters = {
                new SqlParameter("@Id", product.ProductId),
                new SqlParameter("@SupplierId", product.SupplierId),
                new SqlParameter("@CategoryId", product.CategoryId),
                new SqlParameter("@Name", product.ProductName),
                new SqlParameter("@PurchasePrice", product.PurchasePrice),
                new SqlParameter("@RetailPrice", product.RetailPrice),
                new SqlParameter("@CreatedAt", product.CreatedAt),
                new SqlParameter("@Remaining", product.Remaining),
                new SqlParameter("@ShelfLife", product.ShelfLife),
                new SqlParameter("@Unit", product.Unit)
            };

            return Connection.ExecuteNonQuery(query, parameters) > 0;
        }

        // Cập nhật thông tin sản phẩm
        public static bool Update(Product product)
        {
            string query = @"UPDATE Product 
                             SET SupplierId = @SupplierId, CategoryId = @CategoryId, 
                                 ProductName = @Name, PurchasePrice = @PurchasePrice, 
                                 RetailPrice = @RetailPrice, Remaining = @Remaining, 
                                 ShelfLife = @ShelfLife, Unit = @Unit
                             WHERE ProductId = @Id";

            SqlParameter[] parameters = {
                new SqlParameter("@Id", product.ProductId),
                new SqlParameter("@SupplierId", product.SupplierId),
                new SqlParameter("@CategoryId", product.CategoryId),
                new SqlParameter("@Name", product.ProductName),
                new SqlParameter("@PurchasePrice", product.PurchasePrice),
                new SqlParameter("@RetailPrice", product.RetailPrice),
                new SqlParameter("@Remaining", product.Remaining),
                new SqlParameter("@ShelfLife", product.ShelfLife),
                new SqlParameter("@Unit", product.Unit)
            };

            return Connection.ExecuteNonQuery(query, parameters) > 0;
        }

        // Xóa sản phẩm
        public static bool Delete(string productId)
        {
            string query = "DELETE FROM Product WHERE ProductId = @Id";
            SqlParameter param = new SqlParameter("@Id", productId);
            return Connection.ExecuteNonQuery(query, param) > 0;
        }

        // Tìm sản phẩm theo mã sản phẩm
        public static Product GetById(string productId)
        {
            string query = "SELECT * FROM Product WHERE ProductId = @ProductId";
            SqlParameter param = new SqlParameter("@ProductId", productId);

            DataTable dt = Connection.ExecuteQuery(query, param);

            if (dt.Rows.Count == 0)
                return null;

            DataRow row = dt.Rows[0];

            return new Product(
                row["ProductId"].ToString(),
                row["SupplierId"].ToString(),
                row["CategoryId"].ToString(),
                row["ProductName"].ToString(),
                Convert.ToInt32(row["PurchasePrice"]),
                Convert.ToInt32(row["RetailPrice"]),
                Convert.ToDateTime(row["CreatedAt"]),
                Convert.ToDecimal(row["Remaining"]),
                Convert.ToInt32(row["ShelfLife"]),
                row["Unit"].ToString()
            );
        }

        // Tìm sản phẩm theo tên
        public static List<Product> FindByName(string name)
        {
            List<Product> products = new List<Product>();
            string query = "SELECT * FROM Product WHERE ProductName LIKE @Name";
            SqlParameter param = new SqlParameter("@Name", "%" + name + "%");

            DataTable dt = Connection.ExecuteQuery(query, param);

            foreach (DataRow row in dt.Rows)
            {
                products.Add(new Product(
                    row["ProductId"].ToString(),
                    row["SupplierId"].ToString(),
                    row["CategoryId"].ToString(),
                    row["ProductName"].ToString(),
                    Convert.ToInt32(row["PurchasePrice"]),
                    Convert.ToInt32(row["RetailPrice"]),
                    Convert.ToDateTime(row["CreatedAt"]),
                    Convert.ToDecimal(row["Remaining"]),
                    Convert.ToInt32(row["ShelfLife"]),
                    row["Unit"].ToString()
                ));
            }

            return products;
        }
    }
}
