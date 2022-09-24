using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public class TableOrder
    {
        public int Id { get; set; }
        public RestaurantTable RestaurantTable { get; set; }
        public Order Order { get; set; }
        public TimeOnly TimeBegin { get; set; }
        public TimeOnly TimeEnd { get; set; }
    }
}
