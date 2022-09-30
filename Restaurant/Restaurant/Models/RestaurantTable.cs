using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public class RestaurantTable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TableZone Zone { get; set; }
    }
}
