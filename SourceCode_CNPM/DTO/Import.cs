
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DTO{
    
    public class Import
    {
        public string ImportId { get; set; }
        public DateTime ImportDate { get; set; }
        public string SupplierId { get; set; }
        public decimal TotalAmount { get; set; }

        // danh sach chi tiet nhap vao
        public List<ImportDetail> ImportDetailList { get; set; } = new List<ImportDetail>();

        public Import(string importId, DateTime importDate, string supplierId, decimal totalAmount)
        {
            ImportId = importId;
            ImportDate = importDate;
            SupplierId = supplierId;
            TotalAmount = totalAmount;
        }

        // them chi tiet nhap vao danh sach
        public void addImportDetail(ImportDetail importDetail)
        {
            if (importDetail.ImportId.Equals(ImportId))
            {
                ImportDetailList.Add(importDetail);
            }
        }

        // tinh tong tien cua hoa don nhap vao
        public decimal getTotalMount()
        {
            if(ImportDetailList.Count == 0)
                return 0;
            return ImportDetailList.Sum(id => id.TotalPrice);
        }
    }
}