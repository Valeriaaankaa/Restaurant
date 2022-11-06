using Data.Entities;

namespace Restaurant.Models
{
    public class CartViewModel
    {
        public IEnumerable<Dish> Dishes { get; set; }
    }
}