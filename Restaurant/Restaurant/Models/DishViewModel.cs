
using Business.Models;
using System.Web.Mvc;

namespace Restaurant.Models
{
    public class DishViewModel
    {
        public DishModel DishModel { get; set; }
        public IEnumerable<DishCompositionModel> dishCompositionModels { get; set; }
        
        //[HiddenInput(DisplayValue = false)]
        //public List<string> IngredientsIds { get; set; }
    }
}
