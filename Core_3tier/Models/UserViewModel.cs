using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_3tier.Models
{
    public class UserViewModel
    {
        public long UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public int AuthLevel { get; set; }
    }
}
