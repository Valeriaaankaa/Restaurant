using Data.Data;
using Data.Entities;
using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddIngredientViewModel addIngredientRequest)
        {
            var ingredient = new Ingredient()
            {
                Name = addIngredientRequest.Name,
                Amount = addIngredientRequest.Amount,
                ImportDate = addIngredientRequest.ImportDate,
                ExpirationDate = addIngredientRequest.ExpirationDare,
                Price = addIngredientRequest.Price
            };

            await restaurantDb.Ingredients.AddAsync(ingredient);
            await restaurantDb.SaveChangesAsync();
            return RedirectToAction("Add");
        }
    }
}
