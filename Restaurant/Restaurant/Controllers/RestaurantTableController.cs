using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Restaurant.Controllers
{
    public class RestaurantTableController : Controller
    {
        private readonly IRestaurantTableService _restaurantTableService;
        public RestaurantTableController(IRestaurantTableService restaurantTableService)
        {
            _restaurantTableService = restaurantTableService;
        }


        public async Task<IActionResult> Index()
        {
            var restaurantTables = await _restaurantTableService.GetAllAsync();
            return View(restaurantTables);
        }
    }
}
