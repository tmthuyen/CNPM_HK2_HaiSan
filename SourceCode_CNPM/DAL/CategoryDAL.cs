using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using DTO;

namespace DAL
{
    public class CategoryDAL
    {
        // Lấy danh sách tất cả danh mục
        public List<Category> GetAll()
        {
            string query = "SELECT * FROM Category";
            DataTable dt = Connection.ExecuteQuery(query);
            List<Category> categories = new List<Category>();

            foreach (DataRow row in dt.Rows)
            {
                categories.Add(new Category(
                    row["CategoryId"].ToString(),
                    row["CategoryName"].ToString()
                ));
            }

            return categories;
        }

        // Thêm danh mục mới
        public bool Add(Category category)
        {
            string query = @"INSERT INTO Category (CategoryId, CategoryName)
                             VALUES (@Id, @Name)";

            SqlParameter[] parameters = {
                new SqlParameter("@Id", category.CategoryId),
                new SqlParameter("@Name", category.CategoryName)
            };

            return Connection.ExecuteNonQuery(query, parameters) > 0;
        }

        // Tìm danh mục theo mã danh mục
        public Category GetById(string categoryId)
        {
            string query = "SELECT * FROM Category WHERE CategoryId = @CategoryId";
            SqlParameter param = new SqlParameter("@CategoryId", categoryId);

            DataTable dt = Connection.ExecuteQuery(query, param);

            if (dt.Rows.Count == 0)
                return null;

            DataRow row = dt.Rows[0];

            return new Category(
                row["CategoryId"].ToString(),
                row["CategoryName"].ToString()
            );
        }
    }
}
