﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Order
    {
        public string OrderId { get; set; }
        public DateTime CreatedAt { get; set; }
        //  này là trc giảm
        public decimal RawAmount => getRawAmount();
        public decimal TotalAmount { get; set; } // này là phải trả luôn r
        public decimal ReceivedAmount { get; set; }
        // tien thua
        public decimal ChangeAmount => ReceivedAmount - TotalAmount;
        public int UsedPoint { get; set; }
        public string VoucherId { get; set; }
        public string PaymentMethod { get; set; }
        public string CustomerId { get; set; }
        public string Phone { get; set; }
        public string EmployeeId { get; set; }



        // danh sach chi tiet hoa don
        public List<OrderDetail> OrderDetailList { get; set; } = new List<OrderDetail>();

        public Order() { }

        public Order(string orderId, DateTime createdAt, decimal totalAmount, decimal receivedAmount, int usedPoint
        , string paymentMethod, string customerId, string employeeId, string voucherId, List<OrderDetail> orderDetails)
        {
            OrderId = orderId;
            CreatedAt = createdAt;
            TotalAmount = totalAmount;
            ReceivedAmount = receivedAmount;
            UsedPoint = usedPoint;
            PaymentMethod = paymentMethod;
            CustomerId = customerId;
            EmployeeId = employeeId;
            VoucherId = voucherId;
            OrderDetailList = orderDetails;
        }

        // them chi tiet hoa don vao danh sach
        public void addOrderDetail(OrderDetail orderDetail)
        {
            if (orderDetail.OrderId.Equals(OrderId))
            {
                OrderDetailList.Add(orderDetail);
            }
        }

        // tinh tong tien cua hoa don
        public decimal getRawAmount()
        {
            if (OrderDetailList.Count == 0)
                return 0;
            return OrderDetailList.Sum(od => od.Amount * od.RetailPrice);
        }

    }
}