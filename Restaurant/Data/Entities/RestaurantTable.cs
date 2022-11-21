using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Data.Entities
{
    public class RestaurantTable: BaseEntity
    {
        [Required]
        [MaxLength(50, ErrorMessage = "Table name must be less than 50 characters.")]
        public string? Name { get; set; }
        public TableZone Zone { get; set; }
    }
}
