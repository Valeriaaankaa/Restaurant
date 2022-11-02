using Business.Interfaces;
using Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
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
            var res = await _ingredientService.GetAllAsync();

            if (res == null)
            {
                return NotFound();
            }            
            return Ok(res);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        
        public async Task<IActionResult> MenuAsync(int page = 0, string category = "Alcohol")
        { 
            
            var res = await _dishService.GetAllAsync();
            var list_res = res.ToList();
            var categories = res.Select(c => c.DishGroup).Distinct();
            ViewBag.categories = categories;



            //Sort by category. Sort by Price!!!! Not pagination by category!!!!

            const int PageSize = 6; // you can always do something more elegant to set 
            var category_list = list_res.Where(c => c.DishGroup.ToString() == category);
            var count = category_list.Count();
            var data = category_list.Skip(page * PageSize).Take(PageSize).ToList();

            this.ViewBag.MaxPage = (count / PageSize) - (count % PageSize == 0 ? 1 : 0);
            this.ViewBag.Page = page;
            this.ViewBag.Category = category;

            return this.View(data);
        }






        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}