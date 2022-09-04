using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    /// <summary>
    /// User Role; admin or user. Unregistered user - Guest - can't order dish
    /// </summary>
    public enum Role
    {
        User = 1,
        Admin
    }
}
