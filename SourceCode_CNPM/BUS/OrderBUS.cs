using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public  class OrderBUS
    {

        public  List<Product> GetAll()
        {
            return new ProductDAL().GetAll();
        }


        public  List<Product> Sort(List<Product> products, decimal? minPrice, decimal? maxPrice, string categoryId, string name, string sortBy = "RetailPrice", bool ascending = true)
        {
            // Filtering
            var filtered = products.Where(p =>
                (!minPrice.HasValue || p.RetailPrice >= minPrice.Value) &&
                (!maxPrice.HasValue || p.RetailPrice <= maxPrice.Value) &&
                (string.IsNullOrWhiteSpace(categoryId) || p.CategoryId == categoryId) &&
                (string.IsNullOrWhiteSpace(name) || p.ProductName.Contains(name, StringComparison.OrdinalIgnoreCase))
            );

            // Sorting
            filtered = sortBy switch
            {
                "ProductName" => ascending ? filtered.OrderBy(p => p.ProductName) : filtered.OrderByDescending(p => p.ProductName),
                "PurchasePrice" => ascending ? filtered.OrderBy(p => p.PurchasePrice) : filtered.OrderByDescending(p => p.PurchasePrice),
                "CreatedAt" => ascending ? filtered.OrderBy(p => p.CreatedAt) : filtered.OrderByDescending(p => p.CreatedAt),
                "Unit" => ascending ? filtered.OrderBy(p => p.Unit) : filtered.OrderByDescending(p => p.Unit),
                _ => ascending ? filtered.OrderBy(p => p.RetailPrice) : filtered.OrderByDescending(p => p.RetailPrice),
            };

            return filtered.ToList();
        }

    }

}
