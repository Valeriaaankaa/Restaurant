using System.ComponentModel.DataAnnotations;
using Restaurant.Models;
using Business.Models;
namespace Restaurant.Models
{
    public class OrderViewModel
    {
        [Required(ErrorMessage = "Please enter address")]
        public string? Address { get; set; }
        //public ICollection<CartLine>? Lines { get; set; }

    }
}