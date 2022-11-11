namespace Restaurant.Models
{
    public class AddIngredientViewModel
    {
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public DateTime ImportDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public decimal Price { get; set; }
    }
}
