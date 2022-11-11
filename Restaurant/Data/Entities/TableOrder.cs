using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class TableOrder: BaseEntity
    {   
        public DateTime TimeBegin { get; set; }
        public DateTime TimeEnd { get; set; }
        public int RestaurantTableId { get; set; }
        public RestaurantTable RestaurantTable { get; set; }
    }
}
