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
            throw new NotImplementedException();
        }

        public void DeleteObject(List<Ingredient> ingred)
        {
            Console.Write("Enter the name of the ingredient you want to delete:");
            string ingrname = Console.ReadLine();
            ingred.RemoveAll(x => x.IngredientName == ingrname);
        }

        public string Print()
        {
            return $"Ingredient ID: {IngredientId}\n" + $"Name: {IngredientName}\n" + $"Cost: {IngredientPrice}\n" + $"IngredientAmount: {IngredientAmount}\n"
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
                    ingred.FirstOrDefault(x => x.IngredientPrice == ingredPrice && x.IngredientName == ingredname);
                    break;
                case 2:
                    Console.Write("Write new amount:");
                    decimal ingredamount = Convert.ToDecimal(Console.ReadLine());
                    ingred.FirstOrDefault(x => x.IngredientAmount == ingredamount && x.IngredientName==ingredname && ingredamount>=0);
                    break;
                case 3:
                    Console.Write("Write day:");
                    int dayimp = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Write month:");
                    int monthimp = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Write year:");
                    int yearimp = Convert.ToInt32(Console.ReadLine());
                    DateTime NewImportDate = new DateTime(yearimp, monthimp, dayimp);
                    ingred.FirstOrDefault(x => x.ImportDate == NewImportDate && x.IngredientName == ingredname);
                    break;
                case 4:
                    Console.Write("Write day:");
                    int dayexp = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Write month:");
                    int monthexp = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Write year:");
                    int yearexp = Convert.ToInt32(Console.ReadLine());
                    DateTime NewExpirationDate = new DateTime(yearexp, monthexp, dayexp);
                    ingred.FirstOrDefault(x => x.ImportDate == NewExpirationDate && x.IngredientName == ingredname && NewExpirationDate>DateTime.Now);
                    break;
                default:
                    Console.WriteLine("Your choice is invalid");
                    break;
            }
        }
    }
}
