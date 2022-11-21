using System.ComponentModel.DataAnnotations;

namespace Data.Entities
{
    public class Dish : BaseEntity
    {
        /// <summary>
        /// Information about dish that user orders
        /// </summary>
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? ImgPath { get; set; }
        [Required]
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public DishGroup DishGroup { get; set; }
        public ICollection<DishComposition>? DishCompositions { get; set; }

    }
}
