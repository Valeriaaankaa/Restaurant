namespace Data.Entities
{
    public class Dish : BaseEntity
    {
        /// <summary>
        /// Information about dish that user orders
        /// </summary>
        public string Name { get; set; }
        public string ImgPath { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public DishGroup DishGroup { get; set; }
        public ICollection<DishComposition> DishCompositions { get; set; }

    }
}
