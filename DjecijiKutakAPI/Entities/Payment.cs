using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DjecijiKutakAPI.Entities
{
    public class Payment : BaseEntity
    {
        public string SubscriptionID { get; set; }
        public string BillingToken { get; set; }
        public string FacilitatorAccessToken { get; set; }
        public string OrderID { get; set; }
        public string PaymentID { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
    }
}
