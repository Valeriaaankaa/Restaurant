using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Data
{
    public interface IRestaurantDbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<DishComposition> DishCompositions { get; set; }
        public DbSet<DishOrder> DishOrders { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<RestaurantTable> RestaurantTables { get; set; }
        public DbSet<RestaurantUser> RestaurantUsers { get; set; }
        public DbSet<TableOrder> TableOrders { get; set; }
    }
}
