using Data.Entities;

namespace Restaurant.Models
{
    public class MenuViewModel
    {
        public SortType SelectSortType { get; set; }

        public IEnumerable<Dish> Dishes { get; set;}

        public IEnumerable<DishGroup> Categories { get; set; }

        public int Page { get; set; } = 0;
        public int MaxPage { get; set; }
        public string Category { get; set; } = "Alcohol";
        public int PageSize { get; } = 6;

    }

    public enum SortType
    {
        ByName, ByCost
    }
}
