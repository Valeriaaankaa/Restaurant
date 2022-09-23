using Restaurant.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Ingredient:IPrintable, IEditObject<Ingredient>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }
        public DateTime ImportDate { get; set; }
        public DateTime ExpirationDate { get; set; }

        public Ingredient CreateObject()
        {
            Ingredient ingredient = new Ingredient();
            //Console.Write("Enter ingredient Id of the new ingredient: ");
            //ingredient.IngredientId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the name of the new ingredient: ");
            ingredient.Name = Console.ReadLine();
            Console.Write("Enter ingredient price of the new ingredient: ");
            ingredient.Price = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter ingredient amoubt of the new ingredient: ");
            ingredient.Amount = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Write day of Import:");
            int dayimp = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write month of Import:");
            int monthimp = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write year of Import:");
            int yearimp = Convert.ToInt32(Console.ReadLine());
            ingredient.ImportDate = new DateTime(yearimp, monthimp, dayimp);
            Console.Write("Write day of Expiration:");
            int dayexp = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write month of Expiration:");
            int monthexp = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write year of Expiration:");
            int yearexp = Convert.ToInt32(Console.ReadLine());
            ingredient.ImportDate = new DateTime(yearexp, monthexp, dayexp);

            return ingredient;
        }

        public void DeleteObject(List<Ingredient> ingred)
        {
            Console.Write("Enter the name of the ingredient you want to delete:");
            string ingrname = Console.ReadLine();
            ingred.RemoveAll(x => x.Name == ingrname);
        }

        public string Print()
        {
            return $"Ingredient ID: {Id}\n" + $"Name: {Name}\n" + $"Cost: {Price}\n" + $"IngredientAmount: {Amount}\n"
                + $"ImportDate: {ImportDate}\n"
                + $"ExpirationDate: {ExpirationDate}\n";
        }

        public void UpdateObject(List<Ingredient> ingred)
        {
            Console.Write("Enter the name of ingredient you want to change: ");
            string ingredname = Console.ReadLine();
            Console.WriteLine("What do you want to change?\n 1.Ingredient price\n2.Ingredient amount\n3.Import Date\n4. Expiration Date\nYour choice:");
            int choise = Convert.ToInt32(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    Console.Write("Write new price:");
                    decimal ingredPrice = Convert.ToDecimal(Console.ReadLine());
                    ingred.Where(i => i.Name == ingredname).ToList().ForEach(p => p.Price = ingredPrice);
                    break;
                case 2:
                    Console.Write("Write new amount:");
                    decimal ingredamount = Convert.ToDecimal(Console.ReadLine());
                    ingred.Where(i => i.Name == ingredname && ingredamount>=0).ToList().ForEach(p => p.Amount = ingredamount);
                    break;
                case 3:
                    Console.Write("Write day:");
                    int dayimp = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Write month:");
                    int monthimp = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Write year:");
                    int yearimp = Convert.ToInt32(Console.ReadLine());
                    DateTime NewImportDate = new DateTime(yearimp, monthimp, dayimp);
                    ingred.Where(i => i.Name == ingredname).ToList().ForEach(p => p.ImportDate = NewImportDate);
                    break;
                case 4:
                    Console.Write("Write day:");
                    int dayexp = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Write month:");
                    int monthexp = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Write year:");
                    int yearexp = Convert.ToInt32(Console.ReadLine());
                    DateTime NewExpirationDate = new DateTime(yearexp, monthexp, dayexp);
                    ingred.Where(i => i.Name == ingredname && NewExpirationDate > DateTime.Now).ToList().ForEach(p => p.ImportDate = NewExpirationDate);
                    break;
                default:
                    Console.WriteLine("Your choice is invalid");
                    break;
            }
        }
    }
}
