using Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class IngredientModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Enter ingredient name")]
        [RegularExpression(@"^[a-zA-Z]*$", ErrorMessage = "Numbers not allowed")]
        public string Name { get; set; }

        [RegularExpression(@"^[1-1000]{1,4}$", ErrorMessage = "RangeAllowed")]
        public decimal Amount { get; set; }
        public DateTime ImportDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public decimal Price { get; set; }
        public ICollection<DishComposition> DishCompositions { get; set; }
        public IngredientGroup IngredientGroup { get; set; }
        public IngredientMeasurement IngredientMeasurement { get; set; }
    }
}
