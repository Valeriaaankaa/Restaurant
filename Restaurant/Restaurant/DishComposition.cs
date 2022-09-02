using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class DishComposition
    {
        public int CompositionId { get; set; }
        public Dish Dish { get; set; }
        public Ingredient Ingredient { get; set; }
        public decimal IngredienAmount { get; set; }
    }
}
