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
        public OrderController(IOrderRepository orderRepository, Cart cartService, IMapper mapper, UserManager<ApplicationUser> userManager)
        {
            this.orderRepository = orderRepository;
            this.cart = cartService;
            this._mapper = mapper;
            this.userManager = userManager;
        }
        public IActionResult Checkout() => View(new OrderViewModel());
        [HttpPost]
        public IActionResult Checkout(OrderViewModel orderViewModel)
        {
            Order order = new() { DishesOrder = new List<DishOrder>()};
            if (cart.Lines.Count() == 0)
                ModelState.AddModelError("", "Your cart is empty");
            if (ModelState.IsValid)
            {
                foreach (var item in cart.Lines)
                {
                    order.DishesOrder.Add(new DishOrder() { Id = item.CartLineID, Amount = item.Quantity, Dish = _mapper.Map<Dish>(item.Dish), DishId = item.Dish.Id, Order = order, OrderId = order.Id });
                }
                order.Address = orderViewModel.Address;
                order.OrderDate = DateTime.Now;
                order.OrderStatus = OrderStatus.Confirmed;
                ApplicationUser user = userManager.FindByNameAsync(User.Identity?.Name).Result;
                // * Connect user & order
                orderRepository.SaveOrder(order);
                return RedirectToAction(nameof(Completed));
            }
            else
                return View(orderViewModel);
        }
        public ViewResult Completed()
        {
            cart.Clear();
            return View();
        }
    }
}
