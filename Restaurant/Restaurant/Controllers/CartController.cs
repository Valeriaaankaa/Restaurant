using Business.Interfaces;
using Data.Entities;
using Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Models;
using Business.Models;
using Newtonsoft.Json;

namespace Restaurant.Controllers
{
    public class CartController : Controller
    {
        private readonly IDishService _dishService;
        private Cart cart;

        public CartController(IDishService dishService, Cart cartService)
        {
            _dishService = dishService;
            cart = cartService;
        }

        public RedirectToActionResult AddToCart(int Id, string returnUrl)
        {
            DishModel dish = _dishService.GetAllAsync().Result.FirstOrDefault(d => d.Id == Id);

            if (dish is not null)
                cart.AddItem(dish, 1);
            return RedirectToAction("Index", new {returnUrl});
        }
        public RedirectToActionResult RemoveFromCart(int dishId, string returnUrl)
        {
            DishModel dish = _dishService.GetAllAsync().Result.FirstOrDefault(d => d.Id == dishId);
            if(dish is not null)
                cart.RemoveLine(dish);
            return RedirectToAction("Index", new { returnUrl });
        }
        public ViewResult Index(string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                Cart = cart,
                ReturnUrl = returnUrl
            });
        }
    }
}
