using Data.Data;
using Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restaurant.Models;

namespace Restaurant.Controllers
{
    public class IngredientController : Controller
    {
        private readonly RestaurantDbContext restaurantDb;
        public IngredientController(RestaurantDbContext restaurantDbContext)
        {
            this.restaurantDb = restaurantDbContext;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var ingredients = await restaurantDb.Ingredients.ToListAsync(); 
            return View(ingredients);
        }

        [HttpPost]
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
        }
    }
}
