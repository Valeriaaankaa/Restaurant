using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class TableOrder: BaseEntity
    {
        public int RestaurantTableId { get; set; }
        [NotMapped]
        public TimeOnly TimeBegin { get; set; }
        [NotMapped]
        public TimeOnly TimeEnd { get; set; }
        [Required]
        public RestaurantTable? RestaurantTable { get; set; }
    }
}
