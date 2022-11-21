using System.ComponentModel.DataAnnotations;

namespace Data.Entities
{
    public class DishComposition: BaseEntity
    {
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public int DishId { get; set; }
        [Required]
        public int IngredientId { get; set; }
        public Dish? Dish { get; set; }
        public Ingredient? Ingredient { get; set; }
        
    }
}
