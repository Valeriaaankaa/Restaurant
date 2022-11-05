using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class DishComposition: BaseEntity
    {
        public Dish Dish { get; set; }
        public Ingredient Ingredient { get; set; }
        public decimal Amount { get; set; }
    }
}
