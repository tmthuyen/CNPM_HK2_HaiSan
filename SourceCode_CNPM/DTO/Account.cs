
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account{
        public string EmployeeId{get; set;}

        public string Username { get; set;}

        public string Password{get; set;}

        public Account(){}

        public Account(string id, string userName, string pass){
            EmployeeId = id;
            Username = userName;
            Password = pass;
        }
    }
    
}