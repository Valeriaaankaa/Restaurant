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
        public DbSet<Dish> Dishes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ingredient>().HasData(
               new Ingredient { Id = 1, DishId = 1, Name = "Water", Amount = 1, ExpirationDate = new DateTime(2011, 1, 30), ImportDate = new DateTime(2011, 1, 1), Price = 5 },
               new Ingredient { Id = 2, DishId = 2, Name = "Beer", Amount = 1, ExpirationDate = new DateTime(2011, 1, 30), ImportDate = new DateTime(2011, 1, 1), Price = 5 },
               new Ingredient { Id = 3, DishId = 3, Name = "Milk", Amount = 1, ExpirationDate = new DateTime(2011, 1, 30), ImportDate = new DateTime(2011, 1, 1), Price = 5 }
               );

            modelBuilder.Entity<Dish>().HasData(
                new Dish
                {
                    Id = 1,
                    Description = "The Botanist gin, Campari, Vermouth Di Torino",
                    DishGroup = DishGroup.Alcohol,
                    ImgPath = "/img/menu/NEGRONI.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "NEGRONI",
                    Price = 1
                    
                },

                new Dish
                {
                    Id = 2,
                    Description = "Tanqueray London Dry gin, Noilly Prat dry vermouth",
                    DishGroup = DishGroup.Alcohol,
                    ImgPath = "/img/menu/martini.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "MARTINI",
                    Price = 2
                },

                new Dish
                {
                    Id = 3,
                    Description = "Sazerac Rye whiskey, Cocchi Vermouth Di Torino",
                    DishGroup = DishGroup.Alcohol,
                    ImgPath = "/img/menu/martini.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "MANHATTAN",
                    Price = 3
                }


               );


            var dishIngredients = modelBuilder.Entity<Dish>();
            dishIngredients.HasMany(c => c.Ingredients)
                    .WithOne(r => r.Dish);


            base.OnModelCreating(modelBuilder);
        }
    }

}
