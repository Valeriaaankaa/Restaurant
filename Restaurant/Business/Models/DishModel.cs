using Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Business.Models
{
    public class DishModel
    {
        
        public int  Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required(ErrorMessage = "Dish Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Image path is required")]
        [RegularExpression(@"(.*\.)(jpg|JPG|gif|GIF|png|PNG)$", ErrorMessage = "Use image string format like: path/filename.image_extension")]
        public string ImgPath { get; set; }
        
        [Required(ErrorMessage = "Price is required"), Range(1, 10000, ErrorMessage = "Please enter a value bigger than {1} and less than {2}")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [StringLength(100, MinimumLength = 5)]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Dish Group is required")]
        public DishGroup DishGroup { get; set; }
        public IEnumerable<DishComposition>? DishCompositions { get; set; }
    }
}
