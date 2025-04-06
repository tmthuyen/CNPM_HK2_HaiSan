
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Data; 

namespace DAL
{
    public class DALBase<T> where T : new()
    {
        private string table = typeof(T).Name;

        public DALBase() { }

        public List<T> getList()
        {
            string sql = $"SELECT * FROM {typeof(T).Name}";

            DataTable dt = ConnectData.GetInstance().selectQuery(sql);
            List<T> list = new List<T>();

            if (dt.Rows.Count == 0) // Kiểm tra có dữ liệu không
            {
                return list;
            }

            // duyet qua tung dong trong DataTable
            foreach (DataRow row in dt.Rows)
            {
                // tao doi tuong chung
                T obj = new T();
                // duyet qua tung cot trong DataTable
                foreach (DataColumn col in dt.Columns)
                {
                    // tim kiem thuoc tinh trong doi tuong
                    // neu tim thay va gia tri khong phai la DBNull
                    PropertyInfo prop = typeof(T).GetProperty(col.ColumnName);
                    if (prop != null && row[col] != DBNull.Value)
                    {
                        // gan gia tri cho thuoc tinh
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


        // xoa theo id
        public void ExecuteDeleteById(string colName, string id)
        {
            string sql = $"DELETE FROM {table} WHERE {colName} = @{colName}";

            Dictionary<string, object> queryParams = new Dictionary<string, object>(){
                { $"@{colName}", id}
            };

            ConnectData.GetInstance().actionQuery(sql, queryParams);
        }

    }
}