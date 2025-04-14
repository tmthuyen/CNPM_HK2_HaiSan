using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CustomerBUS
    {
        private CustomerDAL cusDAL;

        public CustomerBUS()
        {
            cusDAL = new CustomerDAL(); 
        }

        public List<Customer> GetAll()
        {
            return cusDAL.GetAll();
        }

        public List<Customer> Search(string id="", string phone="", string name="")
        {
            return cusDAL.Search(id, phone, name);
        }

        public bool Add(Customer customer)
        {
            if (CheckExist(customer.Phone))
            {
                return cusDAL.Add(customer);
            }
            return false;
        }

        public bool Update(Customer customer)
        {
            return cusDAL.Update(customer);
        }

        public bool CheckExist(string phone)
        {
            return cusDAL.CheckExist("", phone, "");
        }
    }
}
