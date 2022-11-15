﻿using Business.Interfaces;
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

        public async Task<IActionResult> DetailsAsync(int id)
        {
            var dishes = await _dishService.GetAllAsync();       
            return View(dishes);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(DishModel dish)
        {
            if (ModelState.IsValid)
            {
                TempData["successmessage"] = "DISH WAS ADDED SUCCESSFULLY";
                await _dishService.AddAsync(dish);                
            }
            return View(dish);
        }
        public ActionResult Create()
        {
            return View();
        }
        
         

        [HttpGet]
        public async Task<ActionResult> EditAsync(int id)
        {
            var dish = await _dishService.GetByIdAsync(id);
            var dishcomp = await _dishCompositionService.GetAllAsync();

            List <string> Ids = dishcomp.Select(dc => dc.IngredientId.ToString()).ToList();

            DishViewModel dvm = new DishViewModel()
            {
                dishCompositionModels = dishcomp,
                DishModel = dish
                //IngredientsIds = Ids
            };


            return View(dvm);
        }

        [HttpPost]
        public async Task<ActionResult> EditAsync(DishViewModel model)
        {


            if (ModelState.IsValid)
            {
                await _dishService.UpdateAsync(model.DishModel);           
                return RedirectToAction("Details");
            }


            var dishcomp = await _dishCompositionService.GetAllAsync();

            List<string> Ids = dishcomp.Select(dc => dc.IngredientId.ToString()).ToList();

            DishViewModel dvm = new DishViewModel()
            {
                dishCompositionModels = dishcomp,
                DishModel = model.DishModel
                //IngredientsIds = Ids
            };

            return View(dvm);
        }


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
