using Data.Data;
using Data.Entities;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly RestaurantDbContext _restDbContext;
        private readonly RestCart _restcart;

        public ReservationRepository(RestaurantDbContext restDbContext, RestCart restCart)
        {
            this._restDbContext = restDbContext;
            this._restcart = restCart;
        }

        public void CreateReservation(Reservation reservation)
        {
            _restDbContext.Reservations.Add(reservation);

            var tables = _restcart.listCartTables;

            foreach(var table in tables)
            {
                var reservate = new Reservation()
                {
                    RestaurantTableId = table.Id
                };

                _restDbContext.Reservations.Add(reservate);
            }
            _restDbContext.SaveChanges();
            //throw new NotImplementedException();
        }
    }
}
