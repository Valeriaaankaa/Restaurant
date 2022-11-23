using Microsoft.AspNetCore.Mvc;
using Data.Entities;
using Business.Models;
using Restaurant.Models;
using AutoMapper;
using Data.Interfaces;

namespace Restaurant.Controllers
{
    public class OrderController : Controller
    {
        public IOrderRepository repository;
        private Cart cart;
        private IMapper _mapper;
        public OrderController(IOrderRepository repository, Cart cartService, IMapper mapper)
        {
            this.repository = repository;
            this.cart = cartService;
            this._mapper = mapper;
        }
        public IActionResult Checkout() => View(new OrderViewModel());
        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            if (cart.Lines.Count() == 0)
                ModelState.AddModelError("", "Your cart is empty");
            if (ModelState.IsValid)
            {
                foreach (var item in cart.Lines)
                {
                    order.DishesOrder?.Add(_mapper.Map<DishOrder>(item));
                }
                repository.SaveOrder(order);
                return RedirectToAction(nameof(Completed));
            }
            else
                return View(order);
        }
        public ViewResult Completed()
        {
            cart.Clear();
            return View();
        }
    }
}
