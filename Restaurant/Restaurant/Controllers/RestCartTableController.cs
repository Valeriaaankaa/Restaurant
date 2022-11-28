using Data.Entities;
using Data.Interfaces;
using Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Models;

namespace Restaurant.Controllers
{
    public class RestCartTableController : Controller
    {
        private readonly IRestaurantTableRepository _tablerep;
        private readonly RestCart _restCart;

        public RestCartTableController(IRestaurantTableRepository tablerep, RestCart restCart)
        {
            _tablerep = tablerep;
            _restCart = restCart;
        }
        public ViewResult Index()
        {
            var tables = _restCart.GetRestTables();
            _restCart.listCartTables = tables;

            var obj = new RestCartViewModel
            {
                restCart = _restCart,
            };

            return View(obj);
        }

        public RedirectToActionResult addToCart(int id)
        {
            var table = _tablerep.Tables.FirstOrDefault(i => i.Id==id);
            if(table != null)
            {
                _restCart.AddToCart(table);
            }

            return RedirectToAction("Index");
        }
    }
}
