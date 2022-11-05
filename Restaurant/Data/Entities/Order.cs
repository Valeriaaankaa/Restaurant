using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Order: BaseEntity
    {
        public DateTime OrderDate { get; set; }
        public string Address { get; set; }
        public RestaurantUser RestaurantUser { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public List<Dish> DishesOrder { get; set; }
    }
}
