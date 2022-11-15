using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class DishOrder: BaseEntity
    {        
        public int Amount { get; set; }
        public int OrderId { get; set; }
        public int DishId { get; set; }
        public Order Order { get; set; }
        public Dish Dish { get; set; }
    }
}
