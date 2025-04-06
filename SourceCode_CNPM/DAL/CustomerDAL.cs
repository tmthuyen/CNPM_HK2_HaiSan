using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using DTO;


namespace DAL
{
    public class CustomerDAL : DALBase<Customer>
    {
        public CustomerDAL() : base()
        { 
        }

        public List<Customer> GetAllCustomers()
        {
            return getList();
        }

        public Customer GetCustomerById(string id)
        {
            return ExecuteFindById("CustomerId", id);
        }

        public void DeleteById(string id)
        {
            ExecuteDeleteById("CustomerId", id);
        }

        public void AddCustomer(Customer Customer)
        {
            string sql = "INSERT INTO Customer (CustomerId, CustomerName, CustomerPhone, LoyaltyPoint) " +
                         "VALUES (@CustomerId, @CustomerName, @CustomerPhone, @LoyaltyPoint)";

            Dictionary<string, object> queryParams = new Dictionary<string, object>()
                    {
                        { "@CustomerId", Customer.CustomerId },
                        { "@CustomerName", Customer.FullName },
                        { "@CustomerPhone", Customer.CustomerPhone },
                        { "@LoyaltyPoint", Customer.LoyaltyPoint }
                    };

            ConnectData.GetInstance().actionQuery(sql, queryParams);
        }

    }
}

