using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class TableOrder: BaseEntity
    {   
        public TimeOnly TimeBegin { get; set; }
        public TimeOnly TimeEnd { get; set; }
        public int RestaurantTableId { get; set; }
        public RestaurantTable RestaurantTable { get; set; }
    }
}
