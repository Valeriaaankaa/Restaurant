using Data.Entities;

namespace Restaurant.Models
{
    public class RestaurantTableViewModel
    {
        public IEnumerable<RestaurantTable> GetAllTables { get; set; }
    }
}
