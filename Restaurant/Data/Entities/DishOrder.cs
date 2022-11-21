using System.ComponentModel.DataAnnotations;

namespace Data.Entities
{
    public class DishOrder: BaseEntity
    {
        [Required]
        public int Amount { get; set; }
        [Required]
        public int OrderId { get; set; }
        [Required]
        public int DishId { get; set; }
        public Order? Order { get; set; }
        public Dish? Dish { get; set; }
    }
}
