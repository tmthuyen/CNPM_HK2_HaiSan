﻿using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
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

        // báo cáo thông kê
        public DataTable GetNumImp_TotalImp(DateTime fromDate, DateTime toDate)
        {
            return iDAL.GetNumImp_TotalImp(fromDate, toDate);
        }

        // lay gia nhap nho nhat khi sua san pham
        public int GetMinPurchasePro(string proId)
        {
            return iDAL.GetMinPurchasePro(proId);
        }

        // lay danh sách san pham sap het hạn
        public DataTable GetProductNearExpire()
        {
            return iDAL.GetProductNearExpire();
        }

    }
}
