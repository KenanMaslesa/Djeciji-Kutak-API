using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DjecijiKutakAPI.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public bool IsAdmin { get; set; }
        public string Image { get; set; }
        public int PaymentID { get; set; }
        public Payment Payment { get; set; }
        public IList<Favorite> Favorites { get; set; }

        public override string ToString()
        {
            return $"{FirstName.ToLower()}{LastName.ToLower()}";
        }
    }
}
