using Business.Interfaces;
using Data.Entities;
using Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Restaurant.Models;
using System.Diagnostics;

namespace Restaurant.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IIngredientService _ingredientService;
        private readonly IDishService _dishService;

        public HomeController(ILogger<HomeController> logger, IIngredientService ingredientService, IDishService dishService)
        {
            _logger = logger;
            _ingredientService = ingredientService;
            _dishService = dishService;

        }

        

       public async Task<IActionResult> StockAsync(StockViewModel model)
        {
            IEnumerable<Ingredient> Ingredients = await _ingredientService.GetAllAsync();

            IEnumerable<IngredientGroup> Categories = Ingredients.Select(c => c.IngredientGroup).Distinct();

            IEnumerable<Ingredient> category_list;

            if (model.SelectSortType == IngredientSort.ByName)
            {
                category_list = Ingredients.Where(c => c.IngredientGroup.ToString() == model.Category).OrderBy(d => d.Name.ToLower());
            }
            else
            {
                category_list = Ingredients.Where(c => c.IngredientGroup.ToString() == model.Category).OrderBy(d => d.Amount);
            }

            var count = category_list.Count();
            var data = category_list.Skip(model.Page * model.PageSize).Take(model.PageSize).ToList();

            model.MaxPage = (count / model.PageSize) - (count % model.PageSize == 0 ? 1 : 0);
            model.Ingredients = data;
            model.Categories = Categories;

            return this.View(model);
        }


        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Cart()
        {
            //CartViewModel cartViewModel = new() { Dishes = _dishService.GetAllAsync().Result };
            //return View(cartViewModel);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}