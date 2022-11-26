namespace Restaurant.Models
{
    public class DishCompositionEditViewModel
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public int DishId { get; set; }
        public int IngredientId { get; set; }
    }
}
