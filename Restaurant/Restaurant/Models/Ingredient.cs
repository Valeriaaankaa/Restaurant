using Restaurant.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Ingredient:IPrintable
    {
        public int IngredientId { get; set; }
        public string IngredientName { get; set; }
        public decimal IngredientPrice { get; set; }
        public decimal IngredientAmount { get; set; }
        public DateTime ImportDate { get; set; }
        public DateTime ExpirationDate { get; set; }

        public string Print()
        {
            return $"Ingredient ID: {IngredientId}\n" + $"Name: {IngredientName}\n" + $"Cost: {IngredientPrice}\n" + $"IngredientAmount: {IngredientAmount}\n"
                + $"ImportDate: {ImportDate}\n"
                + $"ExpirationDate: {ExpirationDate}\n";
        }
    }
}
