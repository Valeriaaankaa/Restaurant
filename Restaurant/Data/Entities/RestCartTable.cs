using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class RestCartTable
    {
        public int Id { get; set; }
        public RestaurantTable  restaurantTable { get; set; }
        public string RestCartId { get; set; }
    }
}
