using HaiSan;

namespace HaiSan.DTO{
    public class Order
    {
        public string OrderId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public double TotalAmount { get; set; }
        public double ReceivedAmount { get; set; }
        public int UsedPoint { get; set; } = 0;
        public string PaymentMethod { get; set; }
        public string CustomerPhone { get; set; }
        public Employee Employee { get; set; }

        public Order(string orderId, double totalAmount, double receivedAmount, string paymentMethod, string phone, string employeeId)
        {
            OrderId = orderId;
            TotalAmount = totalAmount;
            ReceivedAmount = receivedAmount;
            PaymentMethod = paymentMethod;
            CustomerPhone = phone;
            EmployeeId = employeeId;
        }

        public double GetChangeAmount() => ReceivedAmount - (TotalAmount - UsedPoint);
    }
}