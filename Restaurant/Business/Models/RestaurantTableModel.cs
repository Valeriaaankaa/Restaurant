using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class RestaurantTableModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TableZone Zone { get; set; }
    }
}
