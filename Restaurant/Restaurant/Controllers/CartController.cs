using Business.Interfaces;
using Data.Entities;
using Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Restaurant.Models;
using System.Diagnostics;

namespace Restaurant.Controllers
{
    public class CartController : Controller
    {
        private readonly IDishService _dishService;

        public CartController(IDishService dishService)
        {
            _dishService = dishService;
        }

        public IActionResult Index()
        {
            CartViewModel cartViewModel = new() { Dishes = _dishService.GetAllAsync().Result };
            if(cartViewModel.Dishes.Any())
                return View(cartViewModel);
            return StatusCode(404);
        }
    }
}
