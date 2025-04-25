using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class OrderItem
    {
        public string Name {  get; set; }
        public int Price { get; set; }
        public string Unit {  get; set; }
        public decimal Quantity { get; set; }
        public decimal Total {  get; set; }
    }
}
