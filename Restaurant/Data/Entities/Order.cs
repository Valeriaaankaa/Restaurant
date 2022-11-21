using System.ComponentModel.DataAnnotations;

namespace Data.Entities
{
    public class Order: BaseEntity
    {
        public DateTime OrderDate { get; set; }

        [Required]
        [MaxLength(100)]
        public string Address { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public int TableOrderId { get; set; }
        [Required]
        public ICollection<DishOrder> DishesOrder { get; set; }
        public TableOrder TableOrder { get; set; }
    }
}
