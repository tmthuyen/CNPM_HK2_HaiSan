
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
    public string EmployeeName { get; set; }
    public string Password { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Gender { get; set; }
    public string Status { get; set; }
    public string RoleName { get; set; }
    public string Avatar { get; set; }
    public DateTime DateOfBirth { get; set; }

    public Employee() { }

    public Employee(string employeeId, string employeeName, string password, string phone, string email,
                       string gender, string status, string roleName, string avatar, DateTime dateOfBirth)
    {
        EmployeeId = employeeId;
        EmployeeName = employeeName;
        Password = password;
        Phone = phone;
        Email = email;
        Gender = gender;
        Status = status;
        RoleName = roleName;
        Avatar = avatar;
        DateOfBirth = dateOfBirth;
    }
    }
}