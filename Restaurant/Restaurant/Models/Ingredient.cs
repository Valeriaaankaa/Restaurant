using Restaurant.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }
        public DateTime ImportDate { get; set; }
        public DateTime ExpirationDate { get; set; }

        public Ingredient ()
	    {

	    }

        public Ingredient (string Name, decimal Price, decimal Amount, DateTime ImportDate, DateTime ExpirationDate)
        {
            this.Name =  Name;
            this.Price = Price;
            this.Amount = Amount;
            this.ImportDate = ImportDate;
            this.ExpirationDate = ExpirationDate;
        }

        public void DeleteObject(List<Ingredient> ingred, string ingrname)
        {            
            var ingredname = ingred.FirstOrDefault(u=>u.Name == ingrname);
            ingred.Remove(ingredname);
        }


        public bool UpdateObject(List<Ingredient> Ingredients, Ingredient updateingred)
        {
            var ingredient = Ingredients.FirstOrDefault(u=>u.Name == updateingred.Name);
             if( ingredient == null)
            { 
                return false;               
            }
            else
            {
                Ingredients.Remove(ingredient);
                Ingredients.Add(updateingred);
                return true;   
            }
        }
    }
}
