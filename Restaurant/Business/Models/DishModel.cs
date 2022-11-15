using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class DishModel
    {
        public int  Id { get; set; }
        public string Name { get; set; }
        public string ImgPath { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public DishGroup DishGroup { get; set; }
        public IEnumerable<DishComposition> DishCompositions { get; set; }
    }
}
