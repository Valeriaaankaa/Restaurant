using Business.Interfaces;
using Business.Models;
using Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Restaurant.Controllers
{
    public class TableOrderController : Controller
    {
        private readonly IRestaurantTableService _restaurantTableService;
        private TableOrder tableOrder;

        public TableOrderController(IRestaurantTableService restaurantTableService, TableOrder tableService)
        {
            _restaurantTableService = restaurantTableService;
            tableOrder = tableService;
        }

        public RedirectToActionResult AddToTableOrder(int Id, string returnUrl)
        {
            RestaurantTable table = _restaurantTableService.GetAllAsync().Result.FirstOrDefault(d => d.Id == Id);

            //if (table is not null)
              //  tableOrder.AddItem(table, null,null);
            return RedirectToAction("Index", new { returnUrl });
        }
        public RedirectToActionResult RemoveFromCart(int dishId, string returnUrl)
        {
           /* DishModel dish = _restaurantTableService.GetAllAsync().Result.FirstOrDefault(d => d.Id == dishId);
            if (dish is not null)
                cart.RemoveLine(dish);*/
            return RedirectToAction("Index", new { returnUrl });
        }
      /*  public ViewResult Index(string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                Cart = cart,
                ReturnUrl = returnUrl
            });
        }*/
    }
}
