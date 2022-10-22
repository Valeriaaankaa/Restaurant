using Restaurant.Interfaces;
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
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public DishGroup DishGroup { get; set; }
        public List<Ingredient> Ingredients { get; set; }

        public Dish ()
	    {

	    }
       
        public void DeleteObject(List<Dish> dishes,string dishname)
        {            
            var dish = dishes.FirstOrDefault(u=>u.Name == dishname);
            dishes.Remove(dish);
        }

        public Dish (string name, string description, decimal price, int dishGroup)
	    {
            Name = name;
            Price = price;
            Description = description;
            DishGroup = (DishGroup) dishGroup;
	    }

        public bool UpdateObject(List<Dish> dishes, Dish updatedish)
        {
            var dish = dishes.FirstOrDefault(u=>u.Name == updatedish.Name);

            
             if( dish == null)
            { 
                return false;               
            }
            else
            { dishes.Remove(dish);
            dishes.Add(updatedish);
                return true;   
            }


           
            
        }

    }
}
