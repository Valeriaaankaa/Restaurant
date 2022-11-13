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
        JsonSerializerSettings serializerSettings = new() { PreserveReferencesHandling = PreserveReferencesHandling.Objects };

        public CartController(IDishService dishService)
        {
            _dishService = dishService;
        }

        public RedirectToActionResult AddToCart(int Id, string returnUrl)
        {
            DishModel dish = _dishService.GetAllAsync().Result.FirstOrDefault(d => d.Id == Id);

            if (dish is not null)
            {
                Cart cart = GetCart();
                cart.AddItem(dish, 1);
                SaveCart(cart);
            }
            return RedirectToAction("Index", new {returnUrl});
        }
        public RedirectToActionResult RemoveFromCart(int dishId, string returnUrl)
        {
            DishModel dish = _dishService.GetAllAsync().Result.FirstOrDefault(d => d.Id == dishId);
            if(dish is not null)
            {
                Cart cart = GetCart();
                cart.RemoveLine(dish);
                SaveCart(cart);
            }
            return RedirectToAction("Index", new { returnUrl });
        }
        public IActionResult Index(string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                Cart = GetCart(),
                ReturnUrl = returnUrl
            });
        }
        private Cart GetCart()
        {
            string? cart = HttpContext.Session.GetString("cart");
            Cart dataCart;
            if (cart is not null)
            {
                dataCart = JsonConvert.DeserializeObject<Cart>(cart, serializerSettings) ?? new Cart();
            }
            else
            {
                return new Cart();
            }
            return dataCart;
        }
        private void SaveCart(Cart cart)
        {
            HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(cart, serializerSettings));
        }
    }
}
