using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Data.Entities;

public class ApplicationUser : IdentityUser
{
    [Required]
    //[RegularExpression(@"^[a-zA-Z]*$", ErrorMessage = "Numbers not allowed")]
    public string? FirstName { get; set; }
    [Required]
    public string? LastName { get; set; }
}

public class ApplicationRole : IdentityRole
{

}
