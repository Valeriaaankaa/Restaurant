using Business.Models;

namespace Restaurant.Models
{
    public class CartViewModel
    {
        public IEnumerable<DishModel> Dishes { get; set; }
    }
}