using System.ComponentModel.DataAnnotations;
namespace Data.Entities
{
    public class Ingredient : BaseEntity
    {
        [RegularExpression(@"^[a-zA-Z]*$", ErrorMessage = "Only letters")]
        public string Name { get; set; }
        [Required]
        [Range(0, 999,  ErrorMessage = "Value for amount must be bigger than zero and less than 999.")]
        public decimal Amount { get; set; }
        public DateTime ImportDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public decimal Price { get; set; }
        public ICollection<DishComposition> DishCompositions { get; set; }
        public IngredientGroup IngredientGroup { get; set; }
        public IngredientMeasurement IngredientMeasurement { get; set; }
    }
}