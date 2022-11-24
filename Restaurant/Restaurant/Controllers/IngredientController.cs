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
            _ingredientService = ingredientService;
        }

        [Authorize(Roles = $"{Constants.Roles.Administrator},{Constants.Roles.Manager}")]
        public async Task<IActionResult> Index(string searchString)
        {
            var ingredients = await _ingredientService.GetAllAsync();
            if (!String.IsNullOrEmpty(searchString))
            {
                ingredients = ingredients.Where(s => s.Name!.Contains(searchString));
            }
            return View(ingredients.ToList());
        }


        [HttpPost]
        [Authorize(Roles = $"{Constants.Roles.Administrator},{Constants.Roles.Manager}")]
        public async Task<IActionResult> CreateAsync(Ingredient ingredient)
        {
            if(ingredient.ImportDate>ingredient.ExpirationDate)
            {
                ModelState.AddModelError("ImportDate", "Import date cannot be later than Expiration date");
            }
            if (ModelState.IsValid)
            {
            await _ingredientService.AddAsync(ingredient);
            return RedirectToAction("Index");
            }
            return View(ingredient);
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
            var ingred = await _ingredientService.GetByIdAsync(id);

            return View(ingred);
        }

        [HttpPost]
        [Authorize(Roles = $"{Constants.Roles.Administrator},{Constants.Roles.Manager}")]
        public async Task<ActionResult> EditAsync(Ingredient ingredient)
        {
            if (ingredient.Price <= 0)
            {
                ModelState.AddModelError("Price", "Must be bigger than zero");
            }
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

    }
}