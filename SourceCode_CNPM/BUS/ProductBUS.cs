using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public  class ProductBUS
    {
        private ProductDAL proDAL;

        public ProductBUS()
        {
            proDAL = new ProductDAL();
        }

        public  List<Product> getAll()
        {
            return proDAL.GetAll();
        }

        // get all de lay theeo  LÔ hàng
        public List<Product> GetProductByLoHang()
        {
            return proDAL.GetAll();/// sua tam thời
        }

        public string CreateNewId(string cateId)
        {
            return proDAL.CreateNewId(cateId.Trim());
        }

        public  List<Product> Sort(List<Product> products, decimal? minPrice, decimal? maxPrice, string categoryId, string name)
        {
            var filtered = products.Where(p =>
                (!minPrice.HasValue || p.RetailPrice >= minPrice.Value) &&
                (!maxPrice.HasValue || p.RetailPrice <= maxPrice.Value) &&
                (string.IsNullOrWhiteSpace(categoryId) || p.CategoryId == categoryId) &&
                (string.IsNullOrWhiteSpace(name) || p.ProductName.Contains(name, StringComparison.OrdinalIgnoreCase))
            );

            return filtered.ToList();
        }

        public List<Product> Search(string proId, string proName, string categoryId, string filter="RetailPrice ASC")
        {
            return proDAL.SearchProduct(proId, proName, categoryId, filter);
        }


        public bool Add(Product product)
        {
            return proDAL.Add(product);
        }

        public bool Delete(string proId)
        {
            return proDAL.Delete(proId);
        }

        public bool Update(Product product)
        {
            return proDAL.Update(product);
        }
        
    }
}
