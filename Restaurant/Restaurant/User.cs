using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string UserLogin { get; set; }
        public string UserEmail { get; set; }
        public int UserPhone { get; set; }
        public string UserPassword { get; set; }
        public Role Role { get; set;  }
    }
}
