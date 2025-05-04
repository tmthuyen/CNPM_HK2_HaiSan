
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DTO
{
    public class Import
    {
        public string ImportId { get; set; }
        public string SupplierId { get; set; }
        public DateTime ImportDate { get; set; }
        public int NumOfProducts { get; set; }
        public List<ImportDetail> ImportDetails { get; set; } = new List<ImportDetail>();
        public decimal TotalAmount => ImportDetails.Sum(im => im.TotalPrice);

        public Import() { }

        public Import(string importId, string supId, DateTime importDate, int numOfProducts,
            List<ImportDetail> importDetails)
        {
            ImportId = importId;
            SupplierId = supId;
            ImportDate = importDate;
            NumOfProducts = numOfProducts;
            ImportDetails = importDetails;
        }
    }

}