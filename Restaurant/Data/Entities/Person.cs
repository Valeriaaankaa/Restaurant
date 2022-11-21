using System.ComponentModel.DataAnnotations;

namespace Data.Entities
{
    public class Person : BaseEntity
    {
        [Required]
        [MaxLength(50, ErrorMessage = "First name must be less than 50 characters")]
        public string? Name { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Surname must be less than 50 characters")]
        public string? Surname { get; set; }

        public DateTime BirthDay { get; set; }

        [Required]
        [MaxLength(12, ErrorMessage = "Phone numbers must be less than 12 characters")]
        public string? PhoneNumber { get; set; }
    }
}
