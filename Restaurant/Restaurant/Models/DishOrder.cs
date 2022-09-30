using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public class DishOrder
    {
        public int Id { get; set; }
        public Order Order { get; set; }
        public Dish Dish { get; set; }
        public int amount { get; set; }
    }
}
