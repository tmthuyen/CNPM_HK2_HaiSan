
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO{
    
    public class Supplier
    {
        public string SupplierId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public Supplier() { }

        public Supplier(string supplierId, string name, string address, string email, string phone)
        {
            SupplierId = supplierId;
            Name = name;
            Address = address;
            Email = email;
            Phone = phone;
        }
    }
}