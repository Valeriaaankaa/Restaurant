using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class MenuOrder
    {
        /// <summary>
        /// Information about User that make order in Order. 
        /// Information about Dishes that User want to eat. 
        /// </summary>
        public int MenuOrderId { get; set; }
        public Order Order { get; set; }
        public List<Dish> Dishes { get; set; }
        public int DishAmount { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("MenuOrderId:{0}\n DishAmount:{1}\n Order:{2}\n", MenuOrderId, DishAmount, Order);
            foreach (Dish d in Dishes)
            {
                sb.AppendFormat(d.ToString(), d);
            }
            return sb.ToString();            
        }
    }
}
