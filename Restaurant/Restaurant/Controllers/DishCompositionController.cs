using Business.Services;
using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Business.Models;
using Microsoft.AspNetCore.Authorization;
using Restaurant.Models;
using Data.Entities;
using System.Linq;

namespace Restaurant.Controllers
{
    public class DishCompositionController : Controller
    {

        private readonly ILogger<DishController> _logger;
        private readonly IDishCompositionService _dishCompositionService;
        private readonly IIngredientService _ingredientService;
        private readonly IDishService _dishService;

        public DishCompositionController(ILogger<DishController> logger, IDishCompositionService dishCompositionService, IIngredientService ingredientService,
            IDishService dishService)
        {
            _logger = logger;
            _dishCompositionService = dishCompositionService;
            _ingredientService = ingredientService;
            _dishService = dishService;
        }

        [Authorize(Policy = "RequireAdmin")]
        public async Task<IActionResult> DetailsAsync(int id)
        {
            var dishes = await _dishCompositionService.GetAllAsync();


            return View(dishes);
        }

        [HttpPost]
        [Authorize(Policy = "RequireAdmin")]
        public async Task<IActionResult> CreateAsync(DishCompositionViewModel model)
        {
            if (ModelState.IsValid)
            {     
                var dishes = await _dishService.GetAllAsync();
                var dish = dishes.Where(i => i.Name == model.SelectDishId).FirstOrDefault();

                var ingredients = await _ingredientService.GetAllAsync();
                var ingredient = ingredients.Where(i => i.Name == model.SelectIngredientId).FirstOrDefault();


                DishCompositionModel dcm = new()
                {
                    Amount = model.Amount,
                    DishId = dish.Id,
                    IngredientId = ingredient.Id
                };

                await _dishCompositionService.AddAsync(dcm);
                return RedirectToAction("Details");
            }
            return RedirectToAction("Create");
        }

        [Authorize(Policy = "RequireAdmin")]
        public ActionResult Create()
        {
            return View();
        }



        [HttpGet]
        [Authorize(Policy = "RequireAdmin")]
        public async Task<ActionResult> EditAsync(int id)
        {
            var dishcomposition = await _dishCompositionService.GetByIdAsync(id);            
            return View(dishcomposition);
        }

        [HttpPost]
        [Authorize(Policy = "RequireAdmin")]
        public async Task<ActionResult> EditAsync(DishCompositionModel model)
        {

            if (ModelState.IsValid)
            {
                await _dishCompositionService.UpdateAsync(model);
                return RedirectToAction("Details");
            }

            return RedirectToAction("Edit");
        }

        [Authorize(Policy = "RequireAdmin")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await _dishCompositionService.DeleteAsync(id);
            return RedirectToAction("Details");
        }


    }
}
