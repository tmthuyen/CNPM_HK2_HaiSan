using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class Connection
    {
        static string server = @"loneve\SQLEXPRESS";
        static string db = @"HaiSan";
        private static string connectionString = $"Data Source={server};Initial Catalog=${db};integrated security = true;TrustServerCertificate=True;";


        public Connection()
        {

        }

        // Mở kết nối
        private static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // Truy vấn trả về DataTable (cho SELECT nhiều dòng)
        public static DataTable ExecuteQuery(string query, params SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        // Truy vấn trả về SqlDataReader (nếu muốn đọc từng dòng thủ công)
        public static SqlDataReader ExecuteReader(string query, params SqlParameter[] parameters)
        {
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand(query, conn);

            if (parameters != null)
                cmd.Parameters.AddRange(parameters);

            conn.Open();
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }

        // Truy vấn không trả về (INSERT, UPDATE, DELETE)
        public static int ExecuteNonQuery(string query, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        // Truy vấn trả về 1 giá trị (SELECT COUNT, MAX, MIN,...)
        public static object ExecuteScalar(string query, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    conn.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }
    }

}
