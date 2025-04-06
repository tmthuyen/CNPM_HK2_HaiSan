using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class SupplierDAL : DALBase<Supplier>
    {
        public SupplierDAL() : base()
        {
            
        }

        public List<Supplier> GetAllSuppliers()
        {
            return getList();
        }

        public Supplier GetSupplierById(string id)
        {
            return ExecuteFindById("SupplierId", id);
        }

        public void DeleteById(string id)
        {
            ExecuteDeleteById("SupplierId", id);
        }

        public void AddSupplier(Supplier supplier)
        {
            string sql = "INSERT INTO Supplier (SupplierId, Name, Address, Email, Phone) " +
                         "VALUES (@SupplierId, @Name, @Address, @Email, @Phone)";

            Dictionary<string, object> queryParams = new Dictionary<string, object>()
            {
                { "@SupplierId", supplier.SupplierId },
                { "@Name", supplier.Name },
                { "@Address", supplier.Address },
                { "@Email", supplier.Email },
                { "@Phone", supplier.Phone }
            };

            ConnectData.GetInstance().actionQuery(sql, queryParams);
        }

    }
}
