
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using DAL.Database;
using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Microsoft.Data.SqlClient;
using DTO;

namespace DAL
{

    public class DALBase() {
        private string? serverName;
        private string? dbName;
        private string? username;
        private string? password;
        public DALBase(string serverName, string dbName, string username, string password) : this()
        {
            this.serverName = serverName;
            this.dbName = dbName;
            this.username = username;
            this.password = password;

        }

        public DALBase(string serverName, string dbName) : this()
        {
            this.serverName = serverName;
            this.dbName = dbName;
            this.username = null;
            this.password = null;
        }
    
        public void setID()
        {
            string cnstring = "";
            if (string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password))
            {
                cnstring = $"Server={serverName};Database={dbName};Trusted_Connection=True;TrustServerCertificate=True;";
            }
            else
            {
                cnstring = $"Server={serverName};Database={dbName};User Id={username};Password={password};";
            }
            ConnectData.GetInstance().setConnectionString(cnstring);
            
        }
       
        public DataTable getDataTable(string sql)
        {
            setID();
            return ConnectData.GetInstance().GetDataTable(sql);
        }
        public List<Product> getListWithCmd(SqlCommand cmd)
        {
            setID();
            return ConnectData.GetInstance().ExecuteReader(cmd);
        }
    }
    public class DALBase<T> where T : new()
    {
        private string table = typeof(T).Name;
        public DALBase() { }

        public List<T> getList()
        {
            string sql = $"SELECT * FROM {typeof(T).Name}";

            DataTable dt = ConnectData.GetInstance().selectQuery(sql);
            List<T> list = new List<T>();

            foreach (DataRow row in dt.Rows)
            {
                T obj = new T();
                foreach (DataColumn col in dt.Columns)
                {
                    PropertyInfo prop = typeof(T).GetProperty(col.ColumnName);
                    if (prop != null && row[col] != DBNull.Value)
                    {
                        prop.SetValue(obj, row[col]);
                    }
                }
                list.Add(obj);
            }

            return list;
        }


        // tim kiem theo id
        public T ExecuteFindById(string colName, string id)
        {
            string sql = $"SELECT * FROM {table} where {colName} = @{colName}";

            Dictionary<string, object> queryParams = new Dictionary<string, object>(){
                { $"@{colName}", id}
            };

            DataTable result = ConnectData.GetInstance().selectQuery(sql, queryParams, "");

            if (result.Rows.Count > 0) // Kiểm tra có dữ liệu không
            {
                T obj = new T();
                foreach (DataColumn col in result.Columns)
                {
                    PropertyInfo prop = typeof(T).GetProperty(col.ColumnName);
                    if (prop != null && result.Rows[0][col] != DBNull.Value)
                    {
                        prop.SetValue(obj, result.Rows[0][col]);
                    }
                }
                return obj;
            }

            return default(T);
        }



    }
}