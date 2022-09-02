using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class MenuOrder
    {
        public int MenuOrderId { get; set; }
        public Order Order { get; set; }
        public Dish Dish { get; set; }
        public int DishAmount { get; set; }
    }
}
