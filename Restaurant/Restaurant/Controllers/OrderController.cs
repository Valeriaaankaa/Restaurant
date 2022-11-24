using Microsoft.AspNetCore.Mvc;
using Data.Entities;
using Business.Models;
using Restaurant.Models;
using AutoMapper;
using Data.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace Restaurant.Controllers
{
    public class OrderController : Controller
    {
        private IOrderRepository orderRepository;
        private UserManager<ApplicationUser> userManager;
        private Cart cart;
        private IMapper _mapper;
        public OrderController(IOrderRepository orderRepository, IUserRepository userRepository, Cart cartService, IMapper mapper, UserManager<ApplicationUser> userManager)
        {
            this.orderRepository = orderRepository;
            this.cart = cartService;
            this._mapper = mapper;
            this.userManager = userManager;
        }
        public IActionResult Checkout() => View(new OrderViewModel());
        [HttpPost]
        public IActionResult Checkout(OrderViewModel order)
        {
            if (cart.Lines.Count() == 0)
                ModelState.AddModelError("", "Your cart is empty");
            //if (ModelState.IsValid)
            //{
                

            //    foreach (var item in cart.Lines)
            //    {
            //        order.DishesOrder?.Add(_mapper.Map<DishOrder>(item));
            //    }
            //    repository.SaveOrder(order);
            //    return RedirectToAction(nameof(Completed));
            //}
            //else
                return View(order);
        }
        public ViewResult Completed()
        {
            cart.Clear();
            return View();
        }
    }
}
