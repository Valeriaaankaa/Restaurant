using Business.Interfaces;
using Business.Models;
using Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Models;
using System.Diagnostics;

namespace Restaurant.Controllers
{
    public class DishController : Controller
    {
        private readonly ILogger<DishController> _logger;

        private readonly IIngredientService _ingredientService;
        private readonly IDishService _dishService;

        public DishController(ILogger<DishController> logger, IIngredientService ingredientService, IDishService dishService)
        {
            _logger = logger;
            _ingredientService = ingredientService;
            _dishService = dishService;

        }

        public async Task<IActionResult> DetailsAsync(int id)
        {
            var dishes = await _dishService.GetAllAsync();          
            

            return View(dishes);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateAsync(DishModel dish)
        {
            //if (ModelState.IsValid)
            //{
                await _dishService.AddAsync(dish);
                return RedirectToAction("Details");
            //}
            //return View(dish);
        }
         

        [HttpGet]
        public async Task<ActionResult> EditAsync(int id)
        {
            var dish = await _dishService.GetByIdAsync(id);

            return View(dish);
        }

        [HttpPost]
        public async Task<ActionResult> EditAsync(DishModel model)
        {
            await _dishService.UpdateAsync(model);           
            return RedirectToAction("Details");
        }


        public async Task<IActionResult> DeleteAsync(int id)
        {
            await _dishService.DeleteAsync(id);
            ViewBag.Messsage = "Record Delete Successfully";
            return RedirectToAction("Details");
        }





        public async Task<IActionResult> IndexAsync(MenuViewModel model)
        {
            // TO DO  CREATE PAGINATION CLASS!!
            IEnumerable<DishModel> Dishes = await _dishService.GetAllAsync();

            IEnumerable<DishGroup> Categories = Dishes.Select(c => c.DishGroup).Distinct();

            IEnumerable<DishModel> category_list;

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
