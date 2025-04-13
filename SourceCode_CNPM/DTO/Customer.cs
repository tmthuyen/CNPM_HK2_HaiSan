
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Customer
    {
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Phone { get; set; }
        public int LoyaltyPoint { get; set; }

        public Customer() { }   

        public Customer(string customerId, string fullName, string customerPhone, int loyaltyPoint)
        {
            CustomerId = customerId;
            CustomerName = fullName;
            Phone = customerPhone;
            LoyaltyPoint = loyaltyPoint;
        }


        public void updatePoint(double price)
        {
            LoyaltyPoint += (int)Math.Floor(price / 100);
        }

        public void usedPoint(int usedPoint)
        {
            LoyaltyPoint -= usedPoint;
        }
    }
}