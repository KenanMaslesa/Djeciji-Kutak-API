using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DjecijiKutakAPI.Entities
{
    public class Favorite : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int VideoId { get; set; }
        public Video Video { get; set; }
    }
}
