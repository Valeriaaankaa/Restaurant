using Data.Entities;

namespace Business.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string Address { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public int TableOrderId { get; set; }
        public ICollection<int> DishOrders { get; set; }
    }
}
