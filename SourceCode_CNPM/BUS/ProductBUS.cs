using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public static class ProductBUS
    {
        public static List<Product> getAll()
        {
            return ProductDAL.GetAll();
        }
        public static List<Product> Sort(List<Product> products, decimal? minPrice, decimal? maxPrice, string categoryId, string name)
        {
            var filtered = products.Where(p =>
                (!minPrice.HasValue || p.RetailPrice >= minPrice.Value) &&
                (!maxPrice.HasValue || p.RetailPrice <= maxPrice.Value) &&
                (string.IsNullOrWhiteSpace(categoryId) || p.CategoryId == categoryId) &&
                (string.IsNullOrWhiteSpace(name) || p.ProductName.Contains(name, StringComparison.OrdinalIgnoreCase))
            );

            return filtered.ToList();
        }

        
    }
}
