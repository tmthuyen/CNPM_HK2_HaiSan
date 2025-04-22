using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ExpireProductBUS
    {
        private ExpireProductDAL ExpireProductDAL;

        public ExpireProductBUS()
        {
            ExpireProductDAL = new ExpireProductDAL();
        }
        public List<ExpireProduct> GetAll()
        {
            return ExpireProductDAL.GetAll();
        }

        public List<ExpireProduct> Search(string proId="", string proName="")
        {
            return ExpireProductDAL.Search(proId, proName);
        }

        public int UpdateInventory()
        {
            return ExpireProductDAL.UpdateInventory();
        }

        public int GetTotalLoss(DateTime fromDate, DateTime toDate)
        {
            return ExpireProductDAL.GetTotalLoss(fromDate, toDate);
        }

    }
}
