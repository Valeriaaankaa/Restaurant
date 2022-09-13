using Restaurant.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    
    public class Order:IPrintable
    {
        /// <summary>
        /// Information about User, that make order, place and date
        /// </summary>
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string Address { get; set; }
        public User User { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public List<Dish> OrderDishes { get; set; }

        public string Print()
        {
            return $"OrderId: {OrderId}\n" + $"OrderDate: {OrderDate.ToString()}\n" + $"Address: {Address}\n"
               + "UserOrder Information:" + $"{User.ToString()}\n" + $"OrderStatus: {OrderStatus.ToString()}\n";
        }

       
    }
}
