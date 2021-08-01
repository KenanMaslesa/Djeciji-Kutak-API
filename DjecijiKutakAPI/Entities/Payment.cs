using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DjecijiKutakAPI.Entities
{
    public class Payment : BaseEntity
    {
        public string SubscriptionID { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
    }
}
