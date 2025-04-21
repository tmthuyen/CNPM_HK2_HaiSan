using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ImportBUS
    {
        private ImportDAL iDAL;

        public ImportBUS()
        {
            iDAL = new ImportDAL();
        }

        public List<Import> GetAll()
        {
            return iDAL.GetAll();
        }

        public string CreateNewId()
        {
            return iDAL.CreateNewId();
        }

        public bool Add(Import import)
        {
            return iDAL.Add(import);
        }

    }
}
