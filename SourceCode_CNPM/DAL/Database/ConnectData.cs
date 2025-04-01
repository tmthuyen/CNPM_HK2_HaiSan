using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data;
using Microsoft.Data.SqlClient;

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
    }
}
