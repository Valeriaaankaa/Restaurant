using System.ComponentModel.DataAnnotations;

namespace Data.Entities
{
    public class Admin: BaseEntity
    {
        [Required]
        public string Login { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }

    }
}
