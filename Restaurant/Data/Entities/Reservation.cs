using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Reservation
    {
        public int Id { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z]*$", ErrorMessage = "Only letters")]
        public string FirstName { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z]*$", ErrorMessage = "Only letters")]
        public string LastName { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public DateTime TimeBegin { get; set; }
        [Required]
        public DateTime TimeEnd { get; set; }
        public int RestaurantTableId { get; set; }
    }
}
