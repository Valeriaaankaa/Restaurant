namespace Data.Entities
{
    public class Ingredient : BaseEntity
    {        
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }
        public DateTime ImportDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public IngredientGroup IngredientGroup { get; set; }
    }
}