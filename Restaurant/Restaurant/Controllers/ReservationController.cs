using Data.Entities;
using Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Restaurant.Controllers
{
    public class ReservationController : Controller
    {
        private readonly IReservationRepository _reservationRepository;
        private readonly RestCart _restCart;

        public ReservationController(IReservationRepository reservationRepository, RestCart restCart)
        {
            this._reservationRepository=reservationRepository;
            this._restCart=restCart;
        }

        public IActionResult Checkout()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Checkout(Reservation reservation)
        {


            _restCart.listCartTables= _restCart.GetRestTables();
            if (_restCart.listCartTables.Count == 0)
            {
                ModelState.AddModelError("", "No table reservation!");
            }

            if (ModelState.IsValid)
            {
                _reservationRepository.CreateReservation(reservation);
                return RedirectToAction("Complete");
            }
            return View(reservation);
        }

        public IActionResult Complete()
        {
            ViewBag.Message = "Sent for processing!";
            return View();
        }
    }
}
