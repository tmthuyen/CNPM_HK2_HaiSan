
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
        public string CustomerPhone { get; set; }
        public string FullName { get; set; }
        public int LoyaltyPoint { get; set; }

        public Customer(string customerId, string customerPhone, string fullName, int loyaltyPoint)
        {
            CustomerId = customerId;
            CustomerPhone = customerPhone;
            FullName = fullName;
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