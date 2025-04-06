using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using DTO;


namespace DAL
{
    public class ProductDAL : DALBase<Product>
    {
        public ProductDAL() : base()
        { 
        }

        public List<Product> GetAllProducts()
        {
            return getList();
        }

        public Product GetProductById(string id)
        {
            return ExecuteFindById("ProductId", id);
        }

        public void DeleteById(string id)
        {
            ExecuteDeleteById("ProductId", id);
        }

        public void AddProduct(Product product)
        {
            string sql = "INSERT INTO Product (ProductId, ProductName, Quantity, RetailPrice, PurchasePrice, CreatedAt, ExpirationPeriod, Status, CategoryId) " +
                         "VALUES (@ProductId, @ProductName, @Quantity, @RetailPrice, @PurchasePrice, @CreatedAt, @ExpirationPeriod, @Status, @CategoryId)";

            Dictionary<string, object> queryParams = new Dictionary<string, object>()
                    {
                        { "@ProductId", product.ProductId },
                        { "@ProductName", product.ProductName },
                        { "@Quantity", product.Quantity },
                        { "@RetailPrice", product.RetailPrice },
                        { "@PurchasePrice", product.PurchasePrice },
                        { "@CreatedAt", product.CreatedAt },
                        { "@ExpirationPeriod", product.ExpirationPeriod },
                        { "@Status", product.Status },
                        { "@CategoryId", product.CategoryId }
                    };

            ConnectData.GetInstance().actionQuery(sql, queryParams);
        }

    }
}

