using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using DTO;

namespace DAL
{
    public class OrderDAL
    {
        // Lấy danh sách tất cả đơn hàng
        public List<Order> GetAll()
        {
            string query = "SELECT * FROM Orders";
            DataTable dt = Connection.ExecuteQuery(query);
            List<Order> orders = new List<Order>();

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
                    row["EmployeeId"].ToString()
                ));
            }

            return orders;
        }

        // Thêm đơn hàng mới
        public bool Add(Order order)
        {
            string query = @"INSERT INTO Orders (OrderId, CreatedAt, TotalAmount, ReceivedAmount, UsedPoint, 
                                                  PaymentMethod, CustomerId, EmployeeId)
                             VALUES (@Id, @CreatedAt, @TotalAmount, @ReceivedAmount, @UsedPoint, 
                                     @PaymentMethod, @CustomerId, @EmployeeId)";

            SqlParameter[] parameters = {
                new SqlParameter("@Id", order.OrderId),
                new SqlParameter("@CreatedAt", order.CreatedAt),
                new SqlParameter("@TotalAmount", order.TotalAmount),
                new SqlParameter("@ReceivedAmount", order.ReceivedAmount),
                new SqlParameter("@UsedPoint", order.UsedPoint),
                new SqlParameter("@PaymentMethod", order.PaymentMethod),
                new SqlParameter("@CustomerId", order.CustomerId),
                new SqlParameter("@EmployeeId", order.EmployeeId)
            };

            return Connection.ExecuteNonQuery(query, parameters) > 0;
        }
 

        // Tìm đơn hàng theo mã đơn hàng
        public Order GetById(string orderId)
        {
            string query = "SELECT * FROM Orders WHERE OrderId = @OrderId";
            SqlParameter param = new SqlParameter("@OrderId", orderId);

            DataTable dt = Connection.ExecuteQuery(query, param);

            if (dt.Rows.Count == 0)
                return null;

            DataRow row = dt.Rows[0];

            return new Order(
                row["OrderId"].ToString(),
                Convert.ToDateTime(row["CreatedAt"]),
                Convert.ToDecimal(row["TotalAmount"]),
                Convert.ToDecimal(row["ReceivedAmount"]),
                Convert.ToInt32(row["UsedPoint"]),
                row["PaymentMethod"].ToString(),
                row["CustomerId"].ToString(),
                row["EmployeeId"].ToString()
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
                    row["EmployeeId"].ToString()
                ));
            }

            return orders;
        }
    
    
    }
}
