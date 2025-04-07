
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
    public int TotalCost { get; set; }

    public Import() { }

    public Import(string importId, DateTime importDate, int totalCost)
    {
        ImportId = importId;
        ImportDate = importDate;
        TotalCost = totalCost;
    }
}

}