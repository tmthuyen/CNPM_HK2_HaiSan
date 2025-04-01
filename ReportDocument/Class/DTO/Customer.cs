using HaiSan;

namespace HaiSan.DTO{
    public class Customer
    {
        public string CustomerPhone { get; set; }
        public string FullName { get; set; }
        public int LoyaltyPoint { get; set; } = 0;

        public Customer(string phone, string fullName)
        {
            CustomerPhone = phone;
            FullName = fullName;
        }

        public void UpdateLoyaltyPoints(int points) => LoyaltyPoint += points;
    }
}