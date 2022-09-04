using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Restaurant
{
    
    public class Dish
    {
        /// <summary>
        /// Information about dish that user orders
        /// </summary>
        public int DishId { get; set; }
        public string DishName { get; set; }
        public decimal DishPrice { get; set; }
        public string DishDescription { get; set; }
        public DishGroup DishGroup { get; set; }
        public List<Ingredient> Ingredients { get; set; }

        public override string ToString()
        {
            return $"Dish ID: {DishId}\n" + $"Name: {DishName}\n" +  $"Cost: {DishPrice}\n" + $"DishGroup: {DishGroup}\n" + $"Description: {DishDescription}\n" ;
        }

    }
}
