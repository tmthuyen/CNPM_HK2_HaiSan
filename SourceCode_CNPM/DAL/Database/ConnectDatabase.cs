using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
//using System.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.Data.SqlClient;

namespace lab2_CNPM
{
    class ConnectDatabase

    {
        private static string s = @"Data Source=loneve\SQLEXPRESS;Initial Catalog=QUANLYTHUCTAP_LAB5;integrated security = true;TrustServerCertificate=True;";

        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(s);
        }

        public static void actionQuery(string sql)
        {
            SqlConnection sqlConnection = GetSqlConnection();
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand(sql, sqlConnection);

            cmd.ExecuteNonQuery();
        }

        public static DataTable selectQuery(string sql)
        {
            SqlConnection sqlConnection = GetSqlConnection();
            sqlConnection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, sqlConnection);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }
    }
}
