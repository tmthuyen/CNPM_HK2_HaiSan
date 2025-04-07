using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using DTO;

namespace DAL
{
    public class OrderDetailDAL
    {
        // Lấy danh sách tất cả chi tiết đơn hàng
        public List<OrderDetail> GetAll()
        {
            string query = "SELECT * FROM OrderDetail";
            DataTable dt = Connection.ExecuteQuery(query);
            List<OrderDetail> orderDetails = new List<OrderDetail>();

            foreach (DataRow row in dt.Rows)
            {
                orderDetails.Add(new OrderDetail(
                    row["OrderId"].ToString(),
                    row["ProductId"].ToString(),
                    Convert.ToInt32(row["RetailPrice"]),
                    Convert.ToDecimal(row["Amount"])
                ));
            }

            return orderDetails;
        }

        // Thêm chi tiết đơn hàng mới
        public bool Add(OrderDetail orderDetail)
        {
            string query = @"INSERT INTO OrderDetail (OrderId, ProductId, RetailPrice, Amount)
                             VALUES (@OrderId, @ProductId, @RetailPrice, @Amount)";

            SqlParameter[] parameters = {
                new SqlParameter("@OrderId", orderDetail.OrderId),
                new SqlParameter("@ProductId", orderDetail.ProductId),
                new SqlParameter("@RetailPrice", orderDetail.RetailPrice),
                new SqlParameter("@Amount", orderDetail.Amount)
            };

            return Connection.ExecuteNonQuery(query, parameters) > 0;
        }


        // Tìm chi tiết đơn hàng theo mã đơn hàng
        public List<OrderDetail> GetByOrderId(string orderId)
        {
            List<OrderDetail> orderDetails = new List<OrderDetail>();
            string query = "SELECT * FROM OrderDetail WHERE OrderId = @OrderId";
            SqlParameter param = new SqlParameter("@OrderId", orderId);

            DataTable dt = Connection.ExecuteQuery(query, param);

            foreach (DataRow row in dt.Rows)
            {
                orderDetails.Add(new OrderDetail(
                    row["OrderId"].ToString(),
                    row["ProductId"].ToString(),
                    Convert.ToInt32(row["RetailPrice"]),
                    Convert.ToDecimal(row["Amount"])
                ));
            }

            return orderDetails;
        }

        // Tìm chi tiết đơn hàng theo mã sản phẩm
        public List<OrderDetail> GetByProductId(string productId)
        {
            List<OrderDetail> orderDetails = new List<OrderDetail>();
            string query = "SELECT * FROM OrderDetail WHERE ProductId = @ProductId";
            SqlParameter param = new SqlParameter("@ProductId", productId);

            DataTable dt = Connection.ExecuteQuery(query, param);

            foreach (DataRow row in dt.Rows)
            {
                orderDetails.Add(new OrderDetail(
                    row["OrderId"].ToString(),
                    row["ProductId"].ToString(),
                    Convert.ToInt32(row["RetailPrice"]),
                    Convert.ToDecimal(row["Amount"])
                ));
            }

            return orderDetails;
        }
    }
}
