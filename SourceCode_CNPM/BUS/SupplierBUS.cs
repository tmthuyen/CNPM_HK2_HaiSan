using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class SupplierBUS
    {
        private SupplierDAL supDAL;

        public SupplierBUS()
        {
            supDAL = new SupplierDAL();
        }

        public List<Supplier> GetAll()
        {
            return supDAL.GetAll();
        }

        public bool Add(Supplier supplier)
        {
            return supDAL.Add(supplier);
        }

        public string CreateNewId()
        {
            return supDAL.CreateNewId();
        }
    }
}
