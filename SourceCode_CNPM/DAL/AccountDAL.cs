using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DTO;
using Microsoft.Data.SqlClient;

namespace DAL
{
    public class AccountDAL
    {
        private string table = "Account";

        public List<Account> GetAll()
        {
            string query = $"SELECT * FROM {table}";
            DataTable dt = Connection.ExecuteQuery(query);
            List<Account> list = new List<Account>();

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new Account(
                    row["EmployeeId"].ToString(),
                    row["Password"].ToString()
                ));
            }

            return list;
        }

        public bool Add(Account acc)
        {
            string query = $@"INSERT INTO {table} (EmployeeId, Password)
                              VALUES (@Id, @Password)";
            SqlParameter[] parameters = {
                new SqlParameter("@Id", acc.EmployeeId),
                new SqlParameter("@Password", HashPassword(acc.Password))
            };

            return Connection.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool Update(Account acc)
        {
            string query = $@"UPDATE {table}
                              SET Password = @Password 
                              WHERE EmployeeId = @Id";
            SqlParameter[] parameters = {
                new SqlParameter("@Id", acc.EmployeeId),
                new SqlParameter("@Password", HashPassword(acc.Password))
            };

            return Connection.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool Delete(string id)
        {
            string query = $"DELETE FROM {table} WHERE EmployeeId = @Id";
            SqlParameter p = new SqlParameter("@Id", id);
            return Connection.ExecuteNonQuery(query, p) > 0;
        }

        // hass password
        public string HashPassword(string password)
        {
            using (var sha = System.Security.Cryptography.SHA256.Create())
            {
                var bytes = Encoding.UTF8.GetBytes(password);
                var hashBytes = sha.ComputeHash(bytes);
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }
 
        // check password
        public bool VerifyPassword(string hashedPass, string inputPass){
            return hashedPass.Equals(HashPassword(inputPass));
        }
    }
}
