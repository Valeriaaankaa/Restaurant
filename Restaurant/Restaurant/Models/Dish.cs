using Restaurant.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Restaurant
{
    
    public class Dish:IPrintable, IEditObject<Dish>
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

        public string Print()
        {
            return $"Dish ID: {DishId}\n" + $"Name: {DishName}\n" +  $"Cost: {DishPrice}\n" + $"DishGroup: {DishGroup}\n" + $"Description: {DishDescription}\n" ;
        }

       
        public void DeleteObject()
        {
            throw new NotImplementedException();
        }

        Dish IEditObject<Dish>.CreateObject()
        {
            throw new NotImplementedException();
        }

        void IEditObject<Dish>.UpdateObject(List<Dish> dishes)
        {
            Console.Write("Enter the name of dish you want to change: ");
            string dishname = Console.ReadLine();
            Console.WriteLine("What do you want to change?\n 1.Dish price\n2.Dish description\nYour choice:");
            int choise = Convert.ToInt32(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    Console.Write("Write new price:");
                    decimal dishPrice = Convert.ToDecimal(Console.ReadLine());
                    dishes.FirstOrDefault(x => x.DishPrice == dishPrice);
                    break;
                case 2:
                    Console.Write("Write new description:");
                    string dishdesc = Console.ReadLine();
                    dishes.FirstOrDefault(x => x.DishDescription == dishdesc);
                    break;
                    default: Console.WriteLine("Your choice is invalid");
                    break;
            }
        }

    }
}
