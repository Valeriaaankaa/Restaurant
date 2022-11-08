using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Admin: BaseEntity
    {
        public string Login { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }

    }
}
