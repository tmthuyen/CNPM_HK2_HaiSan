
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
    public int NumOfProducts { get; set; }
    public List<ImportDetail> ImportDetails{get;set;} = new List<ImportDetail>();

    public Import() { }

    public Import(string importId, DateTime importDate, int numOfProducts,
        List<ImportDetail> importDetails)
    {
        ImportId = importId;
        ImportDate = importDate;
        NumOfProducts = numOfProducts;
        ImportDetails = importDetails;
    }
}

}