using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using DTO;
using System.Collections;
using System.Linq.Expressions;
using System.Drawing;
using Microsoft.Identity.Client;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DAL
{
    public class OrderDAL
    {
        private OrderDetailDAL orderDetailDAL = new OrderDetailDAL();
        // Lấy danh sách tất cả đơn hàng
        public List<Order> GetAll()
        {
            string query = "SELECT o.*,c.Phone FROM Orders o JOIN Customer c ON o.CustomerId = c.CustomerId";
            DataTable dt = Connection.ExecuteQuery(query);
            List<Order> orders = new List<Order>();

            foreach (DataRow row in dt.Rows)
            {
                List<OrderDetail> orderDetails = orderDetailDAL.GetByOrderId(row["OrderId"].ToString());

                orders.Add(new Order
                {
                    
                    OrderId = row["OrderId"].ToString(),
                    CreatedAt = Convert.ToDateTime(row["CreatedAt"]),
                    TotalAmount = Convert.ToDecimal(row["TotalAmount"]),
                    ReceivedAmount = Convert.ToDecimal(row["ReceivedAmount"]),
                    VoucherId = row["VoucherId"].ToString(),
                    UsedPoint = Convert.ToInt32(row["UsedPoint"]),
                    PaymentMethod = row["PaymentMethod"].ToString(),
                    Phone = row["Phone"].ToString(),
                    EmployeeId = row["EmployeeId"].ToString(),
                    OrderDetailList = orderDetails
                
                });
            }

            return orders;
        }

        // Thêm đơn hàng mới
        public bool Add(Order order)
        {
            string query = @"INSERT INTO Orders (OrderId, CreatedAt, TotalAmount, ReceivedAmount, UsedPoint, 
                                          PaymentMethod, CustomerId, EmployeeId, VoucherId)
                     VALUES (@Id, @CreatedAt, @TotalAmount, @ReceivedAmount, @UsedPoint, 
                             @PaymentMethod, @CustomerId, @EmployeeId, @VoucherId)";

            SqlParameter[] parameters =
                        {
                            new SqlParameter("@Id", order.OrderId),
                            new SqlParameter("@CreatedAt", order.CreatedAt),
                            new SqlParameter("@TotalAmount", order.TotalAmount),
                            new SqlParameter("@ReceivedAmount", order.ReceivedAmount),
                            new SqlParameter("@UsedPoint", order.UsedPoint),
                            new SqlParameter("@PaymentMethod", order.PaymentMethod),
                            new SqlParameter("@CustomerId", order.CustomerId),
                            new SqlParameter("@EmployeeId", order.EmployeeId),
                            new SqlParameter("@VoucherId", (object)order.VoucherId ?? DBNull.Value)
                        };

            bool success = Connection.ExecuteNonQuery(query, parameters) > 0;

            if (!success) return false;

            // Thêm chi tiết đơn hàng
            foreach (var detail in order.OrderDetailList)
            {
                orderDetailDAL.Add(detail);
            }

            return true;
        }



        // Tìm đơn hàng theo mã đơn hàng
        public Order GetById(string orderId)
        {
            string query = "SELECT TOP 1 * FROM Orders WHERE OrderId = @OrderId";
            SqlParameter param = new SqlParameter("@OrderId", orderId);

            DataTable dt = Connection.ExecuteQuery(query, param);

            if (dt.Rows.Count == 0)
                return null;

            DataRow row = dt.Rows[0];

            // Lấy danh sách chi tiết đơn hàng
            List<OrderDetail> orderDetails = orderDetailDAL.GetByOrderId(row["OrderId"].ToString());

            return new Order(
                row["OrderId"].ToString(),
                Convert.ToDateTime(row["CreatedAt"]),
                Convert.ToDecimal(row["TotalAmount"]),
                Convert.ToDecimal(row["ReceivedAmount"]),
                Convert.ToInt32(row["UsedPoint"]),
                row["PaymentMethod"].ToString(),
                row["CustomerId"].ToString(),
                row["EmployeeId"].ToString(),
                row["VoucherId"].ToString(),
                orderDetails
            );
        }

        // Tìm đơn hàng theo mã khách hàng, hoac ma nhan vien ban hang, so tien
        public List<Order> Search(string customerId, string employeeId, decimal? minTotalAmount, decimal? maxTotalAmount)
        {
            List<Order> orders = new List<Order>();
            string query = @"SELECT o.*, c.Phone FROM Orders o
                            JOIN Customer c ON c.CustomerId = o.CustomerId
                            WHERE 1=1"; // Bắt đầu với điều kiện luôn đúng

            // Khởi tạo danh sách tham số
            List<SqlParameter> parameters = new List<SqlParameter>();

            // Thêm điều kiện cho mã khách hàng
            if (!string.IsNullOrWhiteSpace(customerId))
            {
                query += " AND CustomerId = @CustomerId";
                parameters.Add(new SqlParameter("@CustomerId", customerId));
            }

            // Thêm điều kiện cho mã nhân viên
            if (!string.IsNullOrWhiteSpace(employeeId))
            {
                query += " AND EmployeeId = @EmployeeId";
                parameters.Add(new SqlParameter("@EmployeeId", employeeId));
            }

            // Thêm điều kiện cho tổng tiền
            if (minTotalAmount.HasValue)
            {
                query += " AND TotalAmount >= @MinTotalAmount";
                parameters.Add(new SqlParameter("@MinTotalAmount", minTotalAmount.Value));
            }

            if (maxTotalAmount.HasValue)
            {
                query += " AND TotalAmount <= @MaxTotalAmount";
                parameters.Add(new SqlParameter("@MaxTotalAmount", maxTotalAmount.Value));
            }

            // Thực hiện truy vấn
            DataTable dt = Connection.ExecuteQuery(query, parameters.ToArray());


            // Chuyển đổi DataTable thành danh sách đơn hàng
            foreach (DataRow row in dt.Rows)
            {
                Order o = new Order(
                    row["OrderId"].ToString(),
                    Convert.ToDateTime(row["CreatedAt"]),
                    Convert.ToDecimal(row["TotalAmount"]),
                    Convert.ToDecimal(row["ReceivedAmount"]),
                    Convert.ToInt32(row["UsedPoint"]),
                    row["PaymentMethod"].ToString(),
                    row["CustomerId"].ToString(),
                    row["EmployeeId"].ToString(),
                    row["VoucherId"].ToString(),
                    orderDetailDAL.GetByOrderId(row["OrderId"].ToString())
                );

                // them PHone cho orrder 
                o.Phone = row["Phone"]+"";

                orders.Add(o);

            }

            return orders;
        }


        //Kiếm product theo lô 
        public List<ProductImport> GetProductByLoHang()
        {
            string query = @"
                        SELECT 
                            p.ProductId,
                            p.ProductName,
                            i.ImportId,
                            i.Remaining,
                            p.Unit,
                            p.RetailPrice,
                            c.CategoryName
                        FROM Products p
                        JOIN ImportDetail i ON p.ProductId = i.ProductId
                        JOIN Category c ON p.CategoryId = c.CategoryId
                        WHERE i.Remaining > 0
                        ";
            DataTable dt = Connection.ExecuteQuery(query);
            List<ProductImport> products = new List<ProductImport>();

            foreach (DataRow row in dt.Rows)
            {
                products.Add(new ProductImport
                {
                    ProductId = row["ProductId"].ToString(),
                    ProductName = row["ProductName"].ToString(),
                    CategoryName = row["CategoryName"].ToString(),
                    RetailPrice = Convert.ToInt32(row["RetailPrice"]),
                    Remaining = Convert.ToDecimal(row["Remaining"]),
                    Unit = row["Unit"].ToString(),
                    ImportId = row.Table.Columns.Contains("ImportId") ? row["ImportId"].ToString() : null // optional if you add ImportId
                });
            }

            return products;
        }

        // tìm khách theo phone 
        public Customer GetCustomer(string phone)
        {
            string sql = "SELECT * FROM Customer WHERE phone = @phone";
            SqlParameter param = new SqlParameter("@phone", phone);

            DataTable dt = Connection.ExecuteQuery(sql, param);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            DataRow row = dt.Rows[0];
            return new Customer
            {
                CustomerId = row["CustomerId"]?.ToString(),
                CustomerName = row["CustomerName"]?.ToString(),
                LoyaltyPoint = row["LoyaltyPoint"] != DBNull.Value ? Convert.ToInt32(row["LoyaltyPoint"]) : 0
            };
        }

        //Tạo khách mới
        public void insertCustomer(string customerId, string customerName, string phone, int point)
        {
            string sql = "INSERT INTO Customer (CustomerId, CustomerName, Phone, LoyaltyPoint) VALUES (@customerId, @customerName, @phone, @point)";

            try
            {
                SqlParameter[] param =
                        {
                            new SqlParameter("@customerId", customerId),
                            new SqlParameter("@customerName", customerName),
                            new SqlParameter("@phone", phone),
                            new SqlParameter("@point", point),
                        };
                Connection.ExecuteNonQuery(sql, param);
            }
            catch (Exception ex)
            {
            }

        }

        //Update điểm cho khách hàng cũ
        public void InsertPoint(string customerId, int point)
        {
            string sql = "UPDATE Customer SET LoyaltyPoint = @point WHERE CustomerId= @customerId";

            try
            {
                SqlParameter[] param =
                        {
                            new SqlParameter("@customerId", customerId),
                            new SqlParameter("@point", point),
                        };
                Connection.ExecuteNonQuery(sql, param);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating loyalty points: {ex.Message}");
            }
        }

        

        //Update tên khách hàng nếu sai
        public void ChangeName(string cusId,string name)
        {
            string sql = "UPDATE Customer SET CustomerName = @Name WHERE CustomerId= @customerId";

            try
            {
                SqlParameter[] param =
                        {
                            new SqlParameter("@customerId", cusId),
                            new SqlParameter("@point", name),
                        };
                Connection.ExecuteNonQuery(sql, param);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating customer name: {ex.Message}");
            }
        }
        public int GetPoint(string customerId)
        {
            string sql = "SELECT LoyaltyPoint FROM Customer WHERE CustomerId = @customerId";
            SqlParameter[] param = { new SqlParameter("@customerId", customerId) };
            var result = Connection.ExecuteScalar(sql, param);

            return result != DBNull.Value ? Convert.ToInt32(result) : 0;
        }

        //lấy hết id (để tạo id mio1)
        public string[] GetAllCustomerId()
        {
            string sql = "SELECT CustomerId FROM Customer";

            DataTable dt = Connection.ExecuteQuery(sql);
            string[] ids = new string[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ids[i] = dt.Rows[i]["CustomerId"].ToString();
            }

            return ids;
        }
        //lấy hết id cũa oder để có id mới
        public string[] GetAllOrderId()
        {
            string sql = "SELECT OrderId FROM Orders";

            DataTable dt = Connection.ExecuteQuery(sql);
            string[] ids = new string[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ids[i] = dt.Rows[i]["OrderId"].ToString();
            }

            return ids;
        }


        // lay doanh sash đơn hang cua customer
        public List<Order> GetOrderByCus(string cusId, string cusPhone)
        {
            List<Order> orders = new List<Order>();
            string query = @"SELECT o.*, c.Phone FROM Orders o
                JOIN Customer c ON c.CustomerId = o.CustomerId
                WHERE o.CustomerId = @cusId AND c.Phone = @cusPhone";
            
            DataTable dt = Connection.ExecuteQuery(query, new SqlParameter[]
            {
                new SqlParameter("@cusId", cusId),
                new SqlParameter("@cusPhone", cusPhone)
            });

            foreach (DataRow row in dt.Rows)
            {
                List<OrderDetail> orderDetails = orderDetailDAL.GetByOrderId(row["OrderId"].ToString());
                Order o = new Order(
                    row["OrderId"].ToString(),
                    Convert.ToDateTime(row["CreatedAt"]),
                    Convert.ToDecimal(row["TotalAmount"]),
                    Convert.ToDecimal(row["ReceivedAmount"]),
                    Convert.ToInt32(row["UsedPoint"]),
                    row["PaymentMethod"].ToString(),
                    row["CustomerId"].ToString(),
                    row["EmployeeId"].ToString(),
                    row["VoucherId"].ToString(),
                    orderDetails
                );
                o.Phone = row["Phone"] + "";

                orders.Add(o);
            }

            return orders;
        }


        // báo caso thông kê
        public DataTable GetNumOrder_Revenue_NumCus(DateTime fromDate, DateTime toDate)
        {
            string sql = @"SELECT 
                    COUNT(o.OrderId) AS NumOrders,
                    COUNT(DISTINCT o.CustomerId) AS NumCustomers,
                    ISNULL(SUM(od.RetailPrice * od.Amount), 0) AS RevenueBefore,
                    ISNULL(SUM(o.TotalAmount), 0)  AS RevenueAfter
                    FROM Orders AS o
                    JOIN OrderDetail AS od ON od.OrderId = o.OrderId
                    WHERE CreatedAt >= @fromDate AND CreatedAt < @toDate";
             
            DataTable dt =  Connection.ExecuteQuery(sql, new SqlParameter[]
                            {
                                new SqlParameter("@fromDate", fromDate),
                                new SqlParameter("@toDate", toDate)
                            });

            dt.Columns.Add("Profit", typeof(decimal));

            decimal doanhThuSau = (int) dt.Rows[0]["RevenueAfter"];

            sql = @"SELECT 
                        SUM(OD.Amount * ID.PurchasePrice) AS TotalCost
                    FROM 
                        Orders O
                        JOIN OrderDetail OD ON O.OrderId = OD.OrderId
                        JOIN ImportDetail ID ON OD.ImportId = ID.ImportId AND OD.ProductId = ID.ProductId
                    WHERE o.CreatedAt >= @fromDate AND o.CreatedAt < @toDate";

            decimal giaVon = Connection.ExecuteScalar(sql, new SqlParameter[]
                            {
                                new SqlParameter("@fromDate", fromDate),
                                new SqlParameter("@toDate", toDate)
                            }) as decimal? ?? 0;  

            dt.Rows[0]["Profit"] = doanhThuSau - giaVon;
            return dt;
        }


        // Tong doanh thu theo ngay
        public DataTable GetRevenueByDay(DateTime fromDate, DateTime toDate)
        {
            string sql = @"
                    SELECT 
                        CAST(o.CreatedAt AS DATE) AS N'OrderDate',
                        COUNT(o.OrderId) AS N'NumOrder',
                        ISNULL(SUM(o.TotalAmount), 0) AS N'Revenue'
                    FROM Orders o
                    WHERE o.CreatedAt >= @fromDate AND o.CreatedAt < @toDate
                    GROUP BY CAST(o.CreatedAt AS DATE)
                    ORDER BY CAST(o.CreatedAt AS DATE)";

            return Connection.ExecuteQuery(sql, new SqlParameter[]
                    {
                        new SqlParameter("@fromDate", fromDate),
                        new SqlParameter("@toDate", toDate)
                    });
        }
    
        
        // top san pham ban chay
        public DataTable GetTopProduct(DateTime fromDate, DateTime toDate, int top = 5)
        {
            string sql = @"SELECT TOP " + top + @"
                        p.ProductName,
                        SUM(od.Amount) AS TotalSold
                    FROM OrderDetail od
                    JOIN Products p ON p.ProductId = od.ProductId
                    JOIN Orders o ON o.OrderId = od.OrderId
                     WHERE o.CreatedAt >= @fromDate AND o.CreatedAt < @toDate
                    GROUP BY p.ProductName
                    ORDER BY TotalSold DESC";
 

            return Connection.ExecuteQuery(sql, new SqlParameter[]
                    {
                        new SqlParameter("@fromDate", fromDate),
                        new SqlParameter("@toDate", toDate)
                    });

        }

        // top san pham ban chay voi thong tin chi tiet
        public DataTable GetTopProductWithInfo(DateTime fromDate, DateTime toDate, int top = 5)
        {
            string sql = @"SELECT TOP " + top + @"
                            p.ProductId,
                            p.ProductName,
                            p.RetailPrice,
                            p.Unit,
                            p.CategoryId,
                            p.CreatedAt,
                            SUM(od.Amount) AS N'Tổng đã bán'
                        FROM OrderDetail od
                        JOIN Products p ON p.ProductId = od.ProductId
                        JOIN Orders o ON o.OrderId = od.OrderId
                         WHERE o.CreatedAt >= @fromDate AND o.CreatedAt < @toDate
                        GROUP BY  
                            p.ProductId, 
                            p.ProductName,
                            p.RetailPrice,
                            p.Unit,
                            p.CategoryId,
                            p.CreatedAt
                        ORDER BY SUM(od.Amount) DESC";


            return Connection.ExecuteQuery(sql, new SqlParameter[]
                    {
                        new SqlParameter("@fromDate", fromDate),
                        new SqlParameter("@toDate", toDate)
                    });

        }
    }
}
