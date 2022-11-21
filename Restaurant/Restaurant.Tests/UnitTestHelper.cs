using Data.Data;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using AutoMapper;
using Business;

namespace Restaurant.Tests
{
    internal static class UnitTestHelper
    {
        public static DbContextOptions<RestaurantDbContext> GetUnitTestDbOptions()
        {
            var options = new DbContextOptionsBuilder<RestaurantDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            using (var context = new RestaurantDbContext(options))
            {
                SeedData(context);
            }

            return options;
        }

        public static IMapper CreateMapperProfile()
        {
            var myProfile = new AutomapperProfile();
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile(myProfile));

            return new Mapper(configuration);
        }

        public static void SeedData(RestaurantDbContext context)
        {
            context.Ingredients.AddRange(
               new Ingredient { Id = 1, Name = "Water", Amount = 23, ExpirationDate = new DateTime(2021, 1, 30), ImportDate = new DateTime(2022, 12, 12), Price = 5, IngredientGroup = IngredientGroup.Drinks },
               new Ingredient { Id = 2, Name = "Pork", Amount = 7, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat }
              );
            
            context.SaveChanges();
        }
    }
}
