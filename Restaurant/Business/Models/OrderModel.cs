using System.ComponentModel.DataAnnotations;
using Business.Models;
namespace Business.Models;

public class OrderModel
{
    [Required]
    public string? FirstName { get; set; }
    [Required]
    public string? LastName { get; set; }
    [Required(ErrorMessage = "Please enter phone number")]
    public string? PhoneNumber { get; set; }
    [Required(ErrorMessage = "Please enter address")]
    public string? Address { get; set; }
    public ICollection<CartLine>? Lines { get; set; }

}
