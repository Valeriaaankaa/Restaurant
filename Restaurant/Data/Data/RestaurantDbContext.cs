using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Data
{
    public class RestaurantDbContext : DbContext, IRestaurantDbContext
    {
        public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options) : base(options)
        {
        }

        public DbSet<Ingredient> Ingredients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ingredient>().HasData(
               new Ingredient { Id = 1, Name = "Water", Amount = 1 , ExpirationDate = new DateTime (2011,1,30), ImportDate = new DateTime(2011, 1, 1), Price = 5 },
               new Ingredient { Id = 2, Name = "Beer", Amount = 1, ExpirationDate = new DateTime(2011, 1, 30), ImportDate = new DateTime(2011, 1, 1), Price = 5 },
               new Ingredient { Id = 3, Name = "Milk", Amount = 1, ExpirationDate = new DateTime(2011, 1, 30), ImportDate = new DateTime(2011, 1, 1), Price = 5 }
               );

            base.OnModelCreating(modelBuilder);
        }
    }
        
}
