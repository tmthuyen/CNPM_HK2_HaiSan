using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO; 
using Microsoft.Data.SqlClient;


namespace DAL
{
    public class EmployeeDAL
    {
        // Lấy danh sách tất cả nhân viên
        public List<Employee> GetAll()
        {
            string query = "SELECT * FROM Employee";
            DataTable dt = Connection.ExecuteQuery(query);
            List<Employee> employees = new List<Employee>();

            foreach (DataRow row in dt.Rows)
            {
                employees.Add(new Employee(
                    row["EmployeeId"].ToString(),
                    row["EmployeeName"].ToString(), 
                    row["Phone"].ToString(),
                    row["Email"]?.ToString(),
                    row["Gender"].ToString(),
                    row["Status"].ToString(),
                    row["RoleName"].ToString(),
                    row["Avatar"]?.ToString(),
                    row["Address"].ToString(),
                    DateTime.Parse(row["DateOfBirth"].ToString())
                ));
            }

            return employees;
        }

        public string CreateNewId()
        {
            string query = "SELECT TOP 1 EmployeeId FROM Employee ORDER BY EmployeeId DESC";
            DataTable dt = Connection.ExecuteQuery(query);

            if (dt.Rows.Count == 0)
            {
                return "EMP01";
            }

            string lastId = dt.Rows[0]["EmployeeId"].ToString(); // "EMP005"
            int number = int.Parse(lastId.Substring(3));         // 5
            number++;                                             // 6

            return "EMP" + number.ToString("D2");                 // "EMP006"
        }

        // Thêm nhân viên mới
        public bool Add(Employee emp)
        {
            string query = @"INSERT INTO Employee (EmployeeId, EmployeeName, Phone, Email, Gender, 
                              Status, RoleName, Address, Avatar, DateOfBirth)
                             VALUES (@Id, @Name, @Phone, @Email, @Gender, @Status, @Role, @Address, @Avatar, @DateOfBirth)";

            SqlParameter[] parameters = {
                new SqlParameter("@Id", emp.EmployeeId),
                new SqlParameter("@Name", emp.EmployeeName), 
                new SqlParameter("@Phone", emp.Phone),
                new SqlParameter("@Email", emp.Email),
                new SqlParameter("@Gender", emp.Gender),
                new SqlParameter("@Status", emp.Status),
                new SqlParameter("@Role", emp.RoleName),
                new SqlParameter("@Address", emp.Address),
                new SqlParameter("@Avatar", emp.Avatar),
                new SqlParameter("@DateOfBirth", emp.DateOfBirth)
            };

            return Connection.ExecuteNonQuery(query, parameters) > 0;
        }

        // Cập nhật thông tin nhân viên
        public bool Update(Employee emp)
        {
            string query = @"UPDATE Employee 
                             SET EmployeeName = @Name, Phone = @Phone, Email = @Email, 
                                 Gender = @Gender, Status = @Status, RoleName = @Role, 
                                 Address = @Address, Avatar = @Avatar, DateOfBirth = @DateOfBirth
                             WHERE EmployeeId = @Id";

            SqlParameter[] parameters = {
                new SqlParameter("@Id", emp.EmployeeId),
                new SqlParameter("@Name", emp.EmployeeName),
                new SqlParameter("@Phone", emp.Phone),
                new SqlParameter("@Email", emp.Email),
                new SqlParameter("@Gender", emp.Gender),
                new SqlParameter("@Status", emp.Status),
                new SqlParameter("@Role", emp.RoleName),
                new SqlParameter("@Address", emp.Address),
                new SqlParameter("@Avatar", emp.Avatar),
                new SqlParameter("@DateOfBirth", emp.DateOfBirth)
            };

            return Connection.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool Delete(string id)
        { 
            string query = "Delete from Employee Where EmployeeId = @id";
            SqlParameter p = new SqlParameter("@id", id);
            return Connection.ExecuteNonQuery(query, p) > 0;
        }

        // kiem tra ràng buộc khóa ngoại
        
        public bool CheckConstraint(string empId){
            string sql = "SELECT COUNT(*) FROM Orders WHERE EmployeeId = @empId";
            return (int)Connection.ExecuteScalar(sql, new SqlParameter("@empId", empId)) > 0;
        }

        // tim theo id
        public Employee GetById(string employeeId)
        {
            string query = "SELECT * FROM Employee WHERE EmployeeId = @EmployeeId";
            SqlParameter param = new SqlParameter("@EmployeeId", employeeId);

            DataTable dt = Connection.ExecuteQuery(query, param);

            if (dt.Rows.Count == 0)
                return null;

            DataRow row = dt.Rows[0];

            return new Employee(
                row["EmployeeId"].ToString(),
                row["EmployeeName"].ToString(), 
                row["Phone"].ToString(),
                row["Email"].ToString(),
                row["Gender"].ToString(),
                row["Status"].ToString(),
                row["RoleName"].ToString(),
                row["Avatar"]?.ToString(),
                row["Address"].ToString(),
                Convert.ToDateTime(row["DateOfBirth"])
            );
        }

        // Tìm nhân viên theo số điện thoại
        public Employee FindByPhone(string phone)
        {
            string query = "SELECT TOP 1 * FROM Employee WHERE Phone = @Phone";
            SqlParameter param = new SqlParameter("@Phone", phone);

            using (SqlDataReader reader = Connection.ExecuteReader(query, param))
            {
                if (reader.Read())
                {
                    return new Employee(
                        reader["EmployeeId"].ToString(),
                        reader["EmployeeName"].ToString(), 
                        reader["Phone"].ToString(),
                        reader["Email"]?.ToString(),
                        reader["Gender"].ToString(),
                        reader["Status"].ToString(),
                        reader["RoleName"].ToString(),
                        reader["Avatar"]?.ToString(),
                        reader["Address"].ToString(),
                        DateTime.Parse(reader["DateOfBirth "].ToString())
                    );
                }
            }
            return null;
        }
    

        // kiem tra dang nhap
        public Employee Login(string username, string password)
        {
            string query = @"SELECT e.* FROM Employee e 
                        JOIN Account a ON e.EmployeeId = a.EmployeeId
                        WHERE a.Username = @name AND a.Password = @pass AND e.Status = 'active'";


            SqlParameter[] parameters = {
                new SqlParameter("@name", username),
                new SqlParameter("@pass", password)
            };

            DataTable dt = Connection.ExecuteQuery(query, parameters);

            if (dt.Rows.Count == 0)
                return null;

            DataRow row = dt.Rows[0];

            return new Employee(
                 row["EmployeeId"].ToString(),
                 row["EmployeeName"].ToString(),
                 row["Phone"].ToString(),
                 row["Email"].ToString(),
                 row["Gender"].ToString(),
                 row["Status"].ToString(),
                 row["RoleName"].ToString(),
                 row["Avatar"].ToString(),
                 row["Address"].ToString(),
                 Convert.ToDateTime(row["DateOfBirth"])
             );
        }

        // thay doi mat khau
        public bool ChangePassword(string empId, string oldPass, string newPass)
        {
            AccountDAL accDAL = new AccountDAL();
            return accDAL.Update(new Account(empId, "", newPass));
        }


    }
}

