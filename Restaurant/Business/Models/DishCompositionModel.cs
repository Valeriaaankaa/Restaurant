using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class DishCompositionModel
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public int IngredientId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime ImportDate { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
