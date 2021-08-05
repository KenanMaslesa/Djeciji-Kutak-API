using DjecijiKutakAPI.Entities;

namespace DjecijiKutakAPI.DTOs
{
    public class PaymentDto
    {
        public int UserId { get; set; }
        public string BillingToken { get; set; }
        public string FacilitatorAccessToken { get; set; }
        public string OrderID { get; set; }
        public string PaymentID { get; set; }
        public string SubscriptionID { get; set; }


        public PaymentDto(Payment payment)
        {
            UserId = payment.UserID;
            BillingToken = payment.BillingToken;
            FacilitatorAccessToken = payment.FacilitatorAccessToken;
            OrderID = payment.OrderID;
            PaymentID = payment.PaymentID;
            SubscriptionID = payment.SubscriptionID;
        }
        public PaymentDto()
        {

        }
    }
}
