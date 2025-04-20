using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using DTO;
using System.Collections;
using System.Linq.Expressions;
using System.Drawing;

namespace DAL
{
    public class OrderDAL
    {
        private OrderDetailDAL orderDetailDAL = new OrderDetailDAL();
        // Lấy danh sách tất cả đơn hàng
        public List<Order> GetAll()
        {
            string query = "SELECT * FROM Orders";
            DataTable dt = Connection.ExecuteQuery(query);
            List<Order> orders = new List<Order>();

            foreach (DataRow row in dt.Rows)
            {
                List<OrderDetail> orderDetails = orderDetailDAL.GetByOrderId(row["OrderId"].ToString());

                orders.Add(new Order(
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
                ));
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
            string query = "SELECT * FROM Orders WHERE 1=1"; // Bắt đầu với điều kiện luôn đúng

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

                orders.Add(new Order(
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
                ));
            }

            return orders;
        }

        // xem coi có phải khách cũ ko
        public string isCustomer(string phone)
        {
            string sql = "SELECT CustomerId FROM Customer WHERE phone = @phone";
            SqlParameter param = new SqlParameter("@phone", phone);

            DataTable dt = Connection.ExecuteQuery(sql, param);
            return dt.Rows.Count > 0 ? dt.Rows[0]["CustomerId"].ToString() : "";
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
        public void insertPoint(string customerId, int point)
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
            string sql = "SELECT OrderId FROM Order";

            DataTable dt = Connection.ExecuteQuery(sql);
            string[] ids = new string[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ids[i] = dt.Rows[i]["OrderId"].ToString();
            }

            return ids;
        }
    }
}
