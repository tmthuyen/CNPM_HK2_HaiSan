using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using System.Data;
using DTO;
using Microsoft.Data.SqlClient;
namespace BUS
{
    

    public class OrderBUS
    {
        private DALBase dalBase; // Instance of the DataConnect class

        public OrderBUS(string serverName, string databaseName) // Constructor to initialize DataConnect
        {
            dalBase = new DALBase(serverName,databaseName);
        }

        public DataTable GetPromotions()
        {
            try
            {
                string query = "SELECT * FROM Promotion where getdate() between ReleaseDate and ExpireDate"; // Your SQL query
                return dalBase.getDataTable(query);
            }
            catch (Exception ex)
            {
                // Handle exceptions (log, throw, etc.)
                Console.WriteLine($"Error in PromotionBUS: {ex.Message}");
                return null;
            }
        }
        public List<Product> GetProduct()
        {
            try
            {
                string query = "SELECT ProductID, ProductName, RetailPrice,Unit,Remaining,categoryID FROM Productt"; // Your SQL query
                DataTable products = dalBase.getDataTable(query);
                List<Product> list = new List<Product>();
                foreach (DataRow row in products.Rows)
                {
                    if (row["ProductID"] != DBNull.Value) // Check for null values
                    {
                        list.Add(new Product(
                                row["ProductID"].ToString(),
                                row["ProductName"].ToString(),
                                Convert.ToDecimal(row["RetailPrice"]), // Correct conversion
                                row["Unit"].ToString(),
                                Convert.ToDecimal(row["Remaining"]), // Correct conversion
                                row["CategoryID"].ToString()

                            ));
                    }
                }
                return list;
            }
            catch (Exception ex)
            {
                // Handle exceptions (log, throw, etc.)
                Console.WriteLine($"Error in PromotionBUS: {ex.Message}");
                return null;
            }
        }
        public List<Product> getFilteredProducts(string categoryID,string priceBegin,string priceEnd,string name)
        {
            try
            {
                string query = "SELECT ProductID, ProductName, RetailPrice, categoryID FROM Productt";
                List<string> conditions = new List<string>();
                SqlCommand cmd = new SqlCommand();

                // Category filter
                if (!string.IsNullOrEmpty(categoryID))
                {
                    conditions.Add("categoryID = @categoryID");
                    cmd.Parameters.AddWithValue("@categoryID", categoryID);
                }

                // Price range filter
                if (!string.IsNullOrEmpty(priceBegin) && !string.IsNullOrEmpty(priceEnd))
                {
                    conditions.Add("RetailPrice BETWEEN @priceBegin AND @priceEnd");
                    cmd.Parameters.AddWithValue("@priceBegin", decimal.Parse(priceBegin));
                    cmd.Parameters.AddWithValue("@priceEnd", decimal.Parse(priceEnd));
                }
                else if (!string.IsNullOrEmpty(priceBegin))
                {
                    conditions.Add("RetailPrice >= @priceBegin");
                    cmd.Parameters.AddWithValue("@priceBegin", decimal.Parse(priceBegin));
                }
                else if (!string.IsNullOrEmpty(priceEnd))
                {
                    conditions.Add("RetailPrice <= @priceEnd");
                    cmd.Parameters.AddWithValue("@priceEnd", decimal.Parse(priceEnd));
                }

                // Name filter (partial match)
                if (!string.IsNullOrEmpty(name))
                {
                    conditions.Add("ProductName LIKE @name");
                    cmd.Parameters.AddWithValue("@name", $"%{name}%");
                }

                // Add WHERE clause if any filters are active
                if (conditions.Count > 0)
                {
                    query += " WHERE " + string.Join(" AND ", conditions);
                }
                cmd.CommandText = query;

                return dalBase.getListWithCmd(cmd);
            }
            catch (Exception ex)
            {
                // Handle exceptions (log, throw, etc.)
                Console.WriteLine($"Error in PromotionBUS: {ex.Message}");
                return null;
            }
        }

        // Add other business logic methods as needed (e.g., GetPromotionById, AddPromotion, etc.)
    }
}