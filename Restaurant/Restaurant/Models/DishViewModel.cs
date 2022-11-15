
using Business.Models;
using System.Web.Mvc;

namespace Restaurant.Models
{
    public class DishViewModel
    {
        public DishModel DishModel { get; set; }
        public IEnumerable<DishCompositionModel> dishCompositionModels { get; set; }        
        public List<int> IngredientsIds { get; set; }
    }
}
