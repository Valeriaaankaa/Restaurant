using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class RestaurantTable: BaseEntity
    {
        public string Name { get; set; }
        public TableZone Zone { get; set; }
    }
}
