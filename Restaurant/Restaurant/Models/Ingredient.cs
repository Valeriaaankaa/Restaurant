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
        public int IngredientId { get; set; }
        public string IngredientName { get; set; }
        public decimal IngredientPrice { get; set; }
        public decimal IngredientAmount { get; set; }
        public DateTime ImportDate { get; set; }
        public DateTime ExpirationDate { get; set; }

        public Ingredient CreateObject()
        {
            Ingredient ingredient = new Ingredient();
            //Console.Write("Enter ingredient Id of the new ingredient: ");
            //ingredient.IngredientId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the name of the new ingredient: ");
            ingredient.IngredientName = Console.ReadLine();
            Console.Write("Enter ingredient price of the new ingredient: ");
            ingredient.IngredientPrice = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter ingredient amoubt of the new ingredient: ");
            ingredient.IngredientAmount = Convert.ToDecimal(Console.ReadLine());
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

        public List<Ingredient> DeleteObject(List<Ingredient> ingred)
        {
            Console.Write("Enter the name of the ingredient you want to delete:");
            string ingrname = Console.ReadLine();
            ingred.RemoveAll(x => x.IngredientName == ingrname);
            return ingred;
        }

        public string Print()
        {
            return $"Ingredient ID: {IngredientId}\n" + $"Name: {IngredientName}\n" + $"Cost: {IngredientPrice}\n" + $"IngredientAmount: {IngredientAmount}\n"
                + $"ImportDate: {ImportDate}\n"
                + $"ExpirationDate: {ExpirationDate}\n";
        }

        public List<Ingredient> UpdateObject(List<Ingredient> ingred)
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
                    ingred.Where(i => i.IngredientName == ingredname).ToList().ForEach(p => p.IngredientPrice = ingredPrice);
                    break;
                case 2:
                    Console.Write("Write new amount:");
                    decimal ingredamount = Convert.ToDecimal(Console.ReadLine());
                    ingred.Where(i => i.IngredientName == ingredname).ToList().ForEach(p => p.IngredientAmount = ingredamount);
                    break;
                case 3:
                    Console.Write("Write day:");
                    int dayimp = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Write month:");
                    int monthimp = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Write year:");
                    int yearimp = Convert.ToInt32(Console.ReadLine());
                    DateTime NewImportDate = new DateTime(yearimp, monthimp, dayimp);
                    ingred.Where(i => i.IngredientName == ingredname).ToList().ForEach(p => p.ImportDate = NewImportDate);
                    break;
                case 4:
                    Console.Write("Write day:");
                    int dayexp = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Write month:");
                    int monthexp = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Write year:");
                    int yearexp = Convert.ToInt32(Console.ReadLine());
                    DateTime NewExpirationDate = new DateTime(yearexp, monthexp, dayexp);
                    ingred.Where(i => i.IngredientName == ingredname && NewExpirationDate > DateTime.Now).ToList().ForEach(p => p.ImportDate = NewExpirationDate);
                    break;
                default:
                    Console.WriteLine("Your choice is invalid");
                    break;
                    
            }
            return ingred;
        }
    }
}
