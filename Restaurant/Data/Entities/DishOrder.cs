using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class DishOrder: BaseEntity
    {
        public Order Order { get; set; }
        public Dish Dish { get; set; }
        public int Amount { get; set; }
    }
}
