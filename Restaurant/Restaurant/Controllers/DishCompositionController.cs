using Business.Services;
using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Business.Models;

namespace Restaurant.Controllers
{
    public class DishCompositionController : Controller
    {

        private readonly ILogger<DishController> _logger;
        private readonly IDishCompositionService _dishCompositionService;

        public DishCompositionController(ILogger<DishController> logger, IDishCompositionService dishCompositionService)
        {
            _logger = logger;
            _dishCompositionService = dishCompositionService;           
        }
        
        public async Task<IActionResult> DetailsAsync(int id)
        {
            var dishes = await _dishCompositionService.GetAllAsync();
            return View(dishes);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(DishCompositionModel model)
        {
            //if (ModelState.IsValid)
            //{
            await _dishCompositionService.AddAsync(model);
            return RedirectToAction("Details");
            //}
            //return View(dish);
        }
        public ActionResult Create()
        {
            return View();
        }



        [HttpGet]
        public async Task<ActionResult> EditAsync(int id)
        {
            var dish = await _dishCompositionService.GetByIdAsync(id);

            return View(dish);
        }

        [HttpPost]
        public async Task<ActionResult> EditAsync(DishCompositionModel model)
        {
            await _dishCompositionService.UpdateAsync(model);
            return RedirectToAction("Details");
        }


        public async Task<IActionResult> DeleteAsync(int id)
        {
            await _dishCompositionService.DeleteAsync(id);
            return RedirectToAction("Details");
        }


    }
}
