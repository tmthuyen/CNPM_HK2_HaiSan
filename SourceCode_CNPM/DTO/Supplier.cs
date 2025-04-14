
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO{
    public class Supplier
{
    public string SupplierId { get; set; }
    public string SupplierName { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }  

    public Supplier() { }

    public Supplier(string supplierId, string supplierName, string phone, string email)
    {
        SupplierId = supplierId;
        SupplierName = supplierName;
        Phone = phone;
        Email = email; 
    }
}
    
    
}