using Business.Interfaces;
using Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Models;
using System.Diagnostics;

namespace Restaurant.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IIngredientService _ingredientService;

        public HomeController(ILogger<HomeController> logger, IIngredientService ingredientService)
        {
            _logger = logger;
            _ingredientService = ingredientService;           
        }

        /*public async Task<IActionResult> IndexAsync()
        {
            var res = await _ingredientService.GetAllAsync();

            if (res == null)
            {
                return NotFound();
            }            
            return Ok(res);
        }*/

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Menu()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}