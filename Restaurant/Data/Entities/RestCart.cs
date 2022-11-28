using Data.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Data.Entities
{
    public class RestCart
    {
        private readonly RestaurantDbContext restaurantDbContext;
        public RestCart(RestaurantDbContext restaurantDbContext)
        {
            this.restaurantDbContext = restaurantDbContext;
        }

        public string RestCardId { get; set; }
        public List<RestCartTable> listCartTables { get; set; }
        public List<RestaurantTable> Tables { get; set; }

        public static RestCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<RestaurantDbContext>();
            string restCartId=session.GetString("CartId")??Guid.NewGuid().ToString();

            session.SetString("CartId", restCartId);

            return new RestCart(context) { RestCardId = restCartId };
        }

        public void AddToCart(RestaurantTable restaurantTable)
        {
            restaurantDbContext.RestCartTables.Add(new RestCartTable
            {
                RestCartId = RestCardId,
                restaurantTable=restaurantTable
            });

            restaurantDbContext.SaveChanges();
        }

        public List<RestCartTable> GetRestTables()
        {
            return restaurantDbContext.RestCartTables.Where(c => c.RestCartId == RestCardId).Include(s=>s.restaurantTable).ToList();
        }
    }
}
