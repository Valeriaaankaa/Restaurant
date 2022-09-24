using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public class DishComposition
    {
        public int Id { get; set; }
        public Dish Dish { get; set; }
        public Ingredient Ingredient { get; set; }
        public decimal amount { get; set; }
    }
}
