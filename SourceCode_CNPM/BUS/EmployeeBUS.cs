﻿using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BUS
{
    public class EmployeeBUS
    {
        private EmployeeDAL empDal;
        private AccountDAL accDAL;

        public EmployeeBUS()
        {
            empDal = new EmployeeDAL();
            accDAL = new AccountDAL();
        }

        public List<Employee> GetAll()
        {
            return empDal.GetAll();
        }

        public string CreateNewId()
        {
            return empDal.CreateNewId();
        }

        public bool Add(Employee emp)
        {
            if (empDal.Add(emp))
            { 
                string username = emp.Email.Split('@')[0];
                Account acc = new Account(emp.EmployeeId, username, "52300070");
                return accDAL.Add(acc);
            }
            return false;
        }

        // check mail exist
        public bool CheckMailExist(string mail){
            return empDal.CheckMailExist(mail);
        }

        public bool Update(Employee emp)
        {
            return empDal.Update(emp);
        }

        public bool Delete(string id)
        {
            if(empDal.CheckConstraint(id)){
                return false;
            }

            accDAL.Delete(id);
            return empDal.Delete(id);
        }
 

        public Employee FindById(string id)
        {
            return empDal.GetById(id);
        }
        

        public Employee Login(string username, string password)
        {

            return empDal.Login(username, accDAL.HashPassword(password));
        }

        public bool ChangePassword(string empId, string oldPass, string newPass)
        {
            return empDal.ChangePassword(empId, oldPass, newPass);
        }

    }
}
