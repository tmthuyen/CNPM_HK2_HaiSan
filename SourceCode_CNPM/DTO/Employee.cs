
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Employee
    {
        public string EmployeeId { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Avatar { get; set; }
        public int Status { get; set; }
        public string Password { get; set; }
        public string RoleName { get; set; }
        public string Gender { get; set; }

        public string Email { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public Employee() { }

        public Employee(string employeeId, string fullName, string phone, string email, string avatar, int status, string password, string roleName, string gender, DateTime? dateOfBirth)
        {
            EmployeeId = employeeId;
            FullName = fullName;
            Phone = phone;
            Email = email;
            Avatar = avatar;
            Status = status;
            Password = password;
            RoleName = roleName;
            Gender = gender;
            DateOfBirth = dateOfBirth;
        }
    }
}