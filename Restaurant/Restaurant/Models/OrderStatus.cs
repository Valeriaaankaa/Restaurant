using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    /// <summary>
    /// OrderStatus State
    /// </summary>
    public enum OrderStatus
    {
        Denied = 1,
        Confirmed,
        InProgress,
        Done
    }
}
