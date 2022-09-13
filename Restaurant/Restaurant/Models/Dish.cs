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

       
        public List<Dish> DeleteObject(List<Dish> dishes)
        {
            Console.Write("Enter the name of the dish you want to delete:");
            string dishname = Console.ReadLine();
            dishes.RemoveAll(x => x.DishName == dishname);
            return dishes;
        }

        //public Dish AddIngredientsToDish(List<Ingredient> ingred)
        //{
        //    Console.Write("Add new ingredient? \n1 - Yes\n2 - No\n3 - Stop adding ingredients\n Your choice:");
        //    int choice = Convert.ToInt32(Console.ReadLine());
        //    for(int i=0; i<ingred.Count; i++)   
        //    {
        //        if (choice == 3)
        //            break;
        //        else
        //        {
        //            Console.WriteLine($"{i+1}. {}")
        //        }
        //    }

        //}

        Dish IEditObject<Dish>.CreateObject()
        {
            Dish dish = new Dish();
            //Console.Write("Enter dish Id of the new dish: ");
            //dish.DishId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the name of the new dish: ");
            dish.DishName=Console.ReadLine();
            Console.Write("Enter dish description of the new dish: ");
            dish.DishDescription = Console.ReadLine();
            Console.Write("Enter dish price of the new dish: ");
            dish.DishPrice = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Choose type of the dish:");
            int i = 1;
            foreach (string t in Enum.GetNames(typeof(DishGroup)))
            {
                Console.WriteLine($"{i}.{t}");
                i++;
            }
            Console.Write("Your choice: ");
            int choicegroup = Convert.ToInt32(Console.ReadLine());
            dish.DishGroup = (DishGroup)choicegroup; //TEST THIS
            //ADD INGREDIENTS
            return dish;
        }

        public List<Dish> UpdateObject(List<Dish> dishes)
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
                    dishes.Where(dish => dish.DishName == dishname).ToList().ForEach(d => d.DishPrice = dishPrice);
                    break;
                case 2:
                    Console.Write("Write new description:");
                    string dishdesc = Console.ReadLine();
                    dishes.Where(dish => dish.DishName == dishname).ToList().ForEach(d => d.DishDescription = dishdesc);
                    break;
                    default: Console.WriteLine("Your choice is invalid");
                    break;
            }
            return dishes;
        }

    }
}
