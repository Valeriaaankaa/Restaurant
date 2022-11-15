using Data.Entities;


namespace Business.Models
{
    public class FilterSearchModel
    {
        public DishGroup? DishGroup { get; set; }
        public int? MinPrice { get; set; }
        public int? MaxPrice { get; set; }
    }
}
