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


        public async Task<IActionResult> IndexAsync()
        {
            
            return View();
        }
        
        public IActionResult Privacy(MenuViewModel model)
        {
                       
            return View();
        }

        
        public async Task<IActionResult> MenuAsync(MenuViewModel model)
        {
            // TO DO  CREATE PAGINATION CLASS!!
            IEnumerable<Dish> Dishes = await _dishService.GetAllAsync();

            IEnumerable<DishGroup> Categories = Dishes.Select(c => c.DishGroup).Distinct();

            IEnumerable<Dish> category_list;

            if (model.SelectSortType == SortType.ByName)
            {
                category_list = Dishes.Where(c => c.DishGroup.ToString() == model.Category).OrderBy(d => d.Name.ToLower());
            }
            else
            {
                category_list = Dishes.Where(c => c.DishGroup.ToString() == model.Category).OrderByDescending(d => d.Price);
            }

            var count = category_list.Count();
            var data = category_list.Skip(model.Page * model.PageSize).Take(model.PageSize).ToList();                       
                                    
            model.MaxPage = (count / model.PageSize) - (count % model.PageSize == 0 ? 1 : 0);
            model.Dishes = data;            
            model.Categories = Categories;            

            return this.View(model);
        }




       


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}