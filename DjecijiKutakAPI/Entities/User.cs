using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace DjecijiKutakAPI.Entities
{
    public class User : IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime LastLoginDate { get; set; }
        public int PaymentID { get; set; }
        public Payment Payment { get; set; }
        public IList<Favorite> Favorites { get; set; }

    }
}
