using System.ComponentModel.DataAnnotations;

namespace Data.Entities
{
    public class Customer: BaseEntity
    {
        [Required]
        public string? Login { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
        public int PersonId { get; set; }
        public int OrderId { get; set; }

        public Order? CustomerOrder { get; set; }
        public Person? Person { get; set; }
    }
}
