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
        public async Task<IActionResult> CreateAsync(DishViewModel dvm)
        {
            //if (ModelState.IsValid)
            //{
                TempData["successmessage"] = "DISH WAS ADDED SUCCESSFULLY";
                var dc = await _dishCompositionService.GetAllAsync();           

                var res = dc.Where(t => dvm.IngredientsIds.Contains(t.Id));               

                dvm.DishModel.DishCompositions = res.Select(dcm => 
                    new DishComposition
                    {
                        Amount = dcm.Amount,
                        Ingredient = dcm.Ingredient                        
                    }).ToList();

                await _dishService.AddAsync(dvm.DishModel);
            // }
            dvm.dishCompositionModels = dc;

            return View(dvm);
        }

        public async Task<ActionResult> CreateAsync()
        {
            var dishcomp = await _dishCompositionService.GetAllAsync();
                        

            DishViewModel dvm = new DishViewModel()
            {
                dishCompositionModels = dishcomp,
            };
            return View(dvm);
        }
               
        [HttpGet]
        public async Task<ActionResult> EditAsync(int id)
        {
            var dishcomp = await _dishCompositionService.GetAllAsync();
            var dish = await _dishService.GetByIdAsync(id);            

            List <string> Ids = dishcomp.Select(dc => dc.Ingredient.Id.ToString()).ToList();

            DishViewModel dvm = new DishViewModel()
            {
                dishCompositionModels = dishcomp,
                DishModel = dish
            };


            return View(dvm);
        }

        [HttpPost]
        public async Task<ActionResult> EditAsync(DishViewModel dvm)
        {
            TempData["successmessage"] = "DISH WAS UPDATED SUCCESSFULLY";

            var dc = await _dishCompositionService.GetAllAsync();
            var res = dc.Where(t => dvm.IngredientsIds.Contains(t.Id));

            dvm.DishModel.DishCompositions = res.Select(dcm =>
                                new DishComposition
                                {
                                    Amount = dcm.Amount,
                                    Ingredient = dcm.Ingredient
                                }).ToList();
                       

            await _dishService.UpdateAsync(dvm.DishModel);


            var dishes = await _dishService.GetAllAsync();

            /* dvm.dishCompositionModels = dc;
             return View(dvm);*/

            return RedirectToAction("Index");

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
