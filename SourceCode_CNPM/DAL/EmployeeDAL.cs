using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using DTO;


namespace DAL
{
    public class EmployeeDAL : DALBase<Employee>
    {
        public EmployeeDAL() : base()
        {
            // Constructor logic if needed
        }

        public List<Employee> GetAllEmployees(){
            return getList();
        }
    
        public Employee GetEmployeeById(string id)
        {
            return ExecuteFindById("EmployeeId", id);
        }

        public void DeleteById(string id)
        {
            ExecuteDeleteById("EmployeeId", id);
        }

        public void AddEmployee(Employee employee)
        {
            string sql = $"INSERT INTO Employee (EmployeeId, Fullname, Phone, Email, Password, Gender, DateOfBirth, Status, Rolename) VALUES (@EmployeeId, @Fullname, @phone, @email, @password, @gender, @dateOfBirth, @status, @rolename)";
            Dictionary<string, object> queryParams = new Dictionary<string, object>(){
                { "@EmployeeId", employee.EmployeeId },
                { "@Fullname", employee.FullName },
                { "@phone", employee.Phone },
                { "@email", employee.Email },
                { "@password", employee.Password },
                { "@gender", employee.Gender },
                { "@dateOfBirth", employee.DateOfBirth },
                { "@status", employee.Status },
                { "@rolename", employee.RoleName }
            };
            ConnectData.GetInstance().actionQuery(sql, queryParams);
        }

         public void UpdateEmployee(Employee employee)
        {
            string sql = $"UPDATE Employee SET Fullname = @Fullname, Phone = @Phone, Email = @Email, Password = @Password, " +
                         "Gender = @Gender, DateOfBirth = @DateOfBirth, Status = @Status, Rolename = @RoleName " +
                         "WHERE EmployeeId = @EmployeeId";

            Dictionary<string, object> queryParams = new Dictionary<string, object>()
            {
                { "@EmployeeId", employee.EmployeeId },
                { "@Fullname", employee.FullName },
                { "@Phone", employee.Phone },
                { "@Email", employee.Email },
                { "@Password", employee.Password },
                { "@Gender", employee.Gender },
                { "@DateOfBirth", employee.DateOfBirth },
                { "@Status", employee.Status },
                { "@RoleName", employee.RoleName }
            };

            ConnectData.GetInstance().actionQuery(sql, queryParams);
        }
    }
}

