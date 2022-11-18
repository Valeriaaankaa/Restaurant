using Business.Interfaces;
using Business.Models;
using Data.Data;
using Data.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restaurant.Models;
using static Restaurant.Constants;

namespace Restaurant.Controllers
{
    public class IngredientController : Controller
    {
        private readonly IIngredientService _ingredientService;
        public IngredientController(IIngredientService ingredientService)
        {
            _ingredientService= ingredientService;
        }

        [Authorize(Roles = $"{Constants.Roles.Administrator},{Constants.Roles.Manager}")]
        public async Task<IActionResult> Index()
        {
            var ingredients = await _ingredientService.GetAllAsync();
            return View(ingredients);
        }


        [HttpPost]
        [Authorize(Roles = $"{Constants.Roles.Administrator},{Constants.Roles.Manager}")]
        public async Task<IActionResult> CreateAsync(Ingredient ingredient)
        {
            //if (ModelState.IsValid)
            //{
            await _ingredientService.AddAsync(ingredient);
            return RedirectToAction("Index");
            //}
            //return View(dish);
        }

        [Authorize(Roles = $"{Constants.Roles.Administrator},{Constants.Roles.Manager}")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpGet]
        [Authorize(Roles = $"{Constants.Roles.Administrator},{Constants.Roles.Manager}")]
        public async Task<ActionResult> EditAsync(int id)
        {
            var dish = await _ingredientService.GetByIdAsync(id);

            return View(dish);
        }

        [HttpPost]
        [Authorize(Roles = $"{Constants.Roles.Administrator},{Constants.Roles.Manager}")]
        public async Task<ActionResult> EditAsync(Ingredient ingredient)
        {
            await _ingredientService.UpdateAsync(ingredient);
            return RedirectToAction("Index");
        }

        [Authorize(Roles = $"{Constants.Roles.Administrator},{Constants.Roles.Manager}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await _ingredientService.DeleteAsync(id);
            ViewBag.Messsage = "Record Delete Successfully";
            return RedirectToAction("Index");
        }




        /*[HttpPost]
        public async Task<IActionResult> Add(AddIngredientViewModel addIngredientRequest)
        {
            var ingredient = new Ingredient()
            {
                Name = addIngredientRequest.Name,
                Amount = addIngredientRequest.Amount,
                ImportDate = addIngredientRequest.ImportDate,
                ExpirationDate = addIngredientRequest.ExpirationDate,
                Price = addIngredientRequest.Price
            };

            await restaurantDb.Ingredients.AddAsync(ingredient);
            await restaurantDb.SaveChangesAsync();
            return RedirectToAction("Add");
        }*/
    }
}
