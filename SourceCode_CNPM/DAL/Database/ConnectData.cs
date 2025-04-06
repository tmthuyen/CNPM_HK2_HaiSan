using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data;
using Microsoft.Data.SqlClient;

namespace DAL
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

        public static ConnectData GetInstance()
        {
            lock (lockObj)
            {
                if (instance == null)
                {
                    instance = new ConnectData();
                }

                return instance;
            }
        }

        public SqlConnection GetSqlConnection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public void actionQuery(string sql)
        {
            using (SqlConnection con = GetSqlConnection())
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
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

        // ho tro them sua xoa
        public void actionQuery(string sql, Dictionary<string, object> parameters)
        {
            using (SqlConnection con = GetSqlConnection())
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            cmd.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                        }
                    }

                    cmd.ExecuteNonQuery();
                }
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
    }
}
