using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data;
using Microsoft.Data.SqlClient;
using DTO;
using System.Reflection.PortableExecutable;
namespace DAL.Database
{
    internal class ConnectData
    {
        private static ConnectData instance;
        private static readonly object lockObj = new object();
        private string s = @"Data Source=loneve\SQLEXPRESS;Initial Catalog=HAISAN;integrated security = true;TrustServerCertificate=True;";
        private SqlConnection con;

        private ConnectData()
        {
            con = new SqlConnection(s);
        }
        public void setConnectionString(string s)
        {
            this.s = s;
            con = new SqlConnection(s);
        }
        public static ConnectData GetInstance()
        {
            lock (lockObj)
            {
                if(instance == null)
                {
                    instance = new ConnectData();
                }

                return instance;
            } 
        }
        public SqlConnection GetSqlConnection()
        {
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public void actionQuery(string sql)
        {
            using(SqlConnection con =  GetSqlConnection())
            { 
                using(SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.ExecuteNonQuery();
                }
            } 
        }

        public DataTable selectQuery(string sql)
        {
            using (SqlConnection con = GetSqlConnection())
            { 
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                return dt;
            } 
        }

        // ho tro tim kiem sap xep tra ve bang du lieu 
        public DataTable selectQuery(string baseSql, Dictionary<string, object> parameters, string orderBy = "")
        {
            using (SqlConnection conn = GetSqlConnection())
            {
                conn.Open();
                string finalSql = baseSql;

                if (!string.IsNullOrEmpty(orderBy))
                {
                    finalSql += " ORDER BY " + orderBy;
                }

                using (SqlCommand cmd = new SqlCommand(finalSql, conn))
                {
                    // Add parameters
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value);
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
        public List<Product> ExecuteReader(SqlCommand cmd)
        {
            SqlConnection connection = con;
            try
            {
                cmd.Connection = connection;
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<Product> products = new List<Product>();

                while (reader.Read())
                {
                    Product product = new Product
                    {
                        ProductId = (reader["ProductID"]).ToString(),
                        ProductName = reader["ProductName"].ToString(),
                        RetailPrice = Convert.ToDecimal(reader["RetailPrice"]),
                        CategoryId = reader["categoryID"].ToString()
                    };

                    products.Add(product);
                }
                return products;  // Returns a SqlDataReader
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., log it, rethrow, etc.)
                throw new Exception("Database operation failed", ex);
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable? GetDataTable(string sql)
        {
            DataTable? dataTable = null;

            try
            {
                using (GetSqlConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            dataTable = new DataTable();
                            adapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error retrieving DataTable: {ex.Message}");
                dataTable = null; // Return null on error
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error retrieving DataTable: {ex.Message}");
                dataTable = null;
            }
            finally
            {
                con.Close();
            }

            return dataTable;
        }
    }
}
