
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DTO{
    public class ExpireProduct
{
    public string ExpireProductId { get; set; }
    public string ImportId { get; set; }
    public string ProductId { get; set; }
    public float Quantity { get; set; }
    public float TotalLoss { get; set; }
    public DateTime ExpiredDate { get; set; } 

    public ExpireProduct() { }

    public ExpireProduct(string id, string proId, string impId, float quantity, int totalLoss, DateTime expriredDate)
    {
        ExpireProductId = id;
        ProductId = proId;
        ImportId = impId;
        Quantity = quantity;
        TotalLoss = totalLoss;
        ExpiredDate = expriredDate;
    }
}

}