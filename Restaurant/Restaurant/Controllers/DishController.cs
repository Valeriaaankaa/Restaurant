using Business.Interfaces;
using Business.Models;
using Data.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Models;
using System.Diagnostics;
using System.Linq;

namespace Restaurant.Controllers
{
    public class DishController : Controller
    {
        private readonly ILogger<DishController> _logger;
        private readonly IIngredientService _ingredientService;
        private readonly IDishService _dishService;
        private readonly IDishCompositionService _dishCompositionService;

        public DishController(ILogger<DishController> logger, 
                            IIngredientService ingredientService, 
                            IDishService dishService,
                            IDishCompositionService dishCompositionService)
        {
            _logger = logger;
            _ingredientService = ingredientService;
            _dishService = dishService;
            _dishCompositionService = dishCompositionService;
        }

        [Authorize(Policy = "RequireAdmin")]
        public async Task<IActionResult> DetailsAsync(int id)
        {
            var dishes = await _dishService.GetAllAsync();   
                      



            return View(dishes);
        }

        [HttpPost]
        [Authorize(Policy = "RequireAdmin")]
        public async Task<IActionResult> CreateAsync(DishViewModel dvm)
        {

            var dc = await _dishCompositionService.GetAllAsync();

            if (ModelState.IsValid)
            {
                TempData["successmessage"] = "DISH WAS ADDED SUCCESSFULLY";     
                await _dishService.AddAsync(dvm.DishModel);
            }

            return View(dvm);
        }

        [Authorize(Policy = "RequireAdmin")]
        public async Task<ActionResult> CreateAsync()
        {           
            return View();
        }
               
        [HttpGet]
        [Authorize(Policy = "RequireAdmin")]
        public async Task<ActionResult> EditAsync(int id)
        {           
            var dish = await _dishService.GetByIdAsync(id);      
            return View(dish);
        }

        [HttpPost]
        [Authorize(Policy = "RequireAdmin")]
        public async Task<ActionResult> EditAsync(DishModel dvm)
        {            
            if (ModelState.IsValid)
            {
                TempData["successmessage"] = "DISH WAS UPDATED SUCCESSFULLY";
                await _dishService.UpdateAsync(dvm);           
            }

            return View(dvm);
        }

        [Authorize(Policy = "RequireAdmin")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await _dishService.DeleteAsync(id);
            ViewBag.Messsage = "Record Delete Successfully";
            return RedirectToAction("Details");
        }


        [HttpPost]
        public ActionResult ChosenCategory(MenuViewModel model)
        {
            
            return RedirectToAction("Index", "Dish", model);
        }

        public async Task<IActionResult> IndexAsync(MenuViewModel model)
        {
            if (model.FilterSearchModel == null)
            {
                model.Dishes = await _dishService.GetAllAsync();
            }
            else
            {
                model.Dishes = await _dishService.GetByFilterAsync(model.FilterSearchModel);
            }

            model.Categories = (await _dishService.GetDishCategoriesAsync()).ToList();
             

            model.Dishes = _dishService.Sort(model.Dishes, model.Category, model.SelectSortType);

            var count = model.Dishes.Count();
            model.Dishes = model.Dishes.Skip(model.Page * model.PageSize).Take(model.PageSize).ToList();
            model.MaxPage = (count / model.PageSize) - (count % model.PageSize == 0 ? 1 : 0);         

            return this.View(model);
        }








            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
