using Data.Data;
using Data.Entities;
using Data.Repositories;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Tests.DataTests
{
        [TestFixture]
        public class IngredientRepositoryTests
    {
            [TestCase(1)]
            [TestCase(2)]
            public async Task IngredientRepository_GetByIdAsync_ReturnsSingleValue(int id)
            {
                using var context = new RestaurantDbContext(UnitTestHelper.GetUnitTestDbOptions());

                var ingredientRepository = new IngredientRepository(context);
                var ingredient = await ingredientRepository.GetByIdAsync(id);

                var expected = ExpectedIngredients.FirstOrDefault(x => x.Id == id);

                Assert.That(ingredient, Is.EqualTo(expected).Using(new IngredientEqualityComparer()), message: "GetByIdAsync method works incorrect");
            }

            [Test]
            public async Task IngredientRepository_GetAllAsync_ReturnsAllValues()
            {
                using var context = new RestaurantDbContext(UnitTestHelper.GetUnitTestDbOptions());

                var ingredientRepository = new IngredientRepository(context);
                var ingredients = await ingredientRepository.GetAllAsync();

                Assert.That(ingredients, Is.EqualTo(ExpectedIngredients).Using(new IngredientEqualityComparer()), message: "GetAllAsync method works incorrect");
            }

            [Test]
            public async Task IngredientRepository_AddAsync_AddsValueToDatabase()
            {
                using var context = new RestaurantDbContext(UnitTestHelper.GetUnitTestDbOptions());

                var ingredientRepository = new IngredientRepository(context);
                var ingredient = new Ingredient { Id = 3, Name = "Ingr3", Price = 4, Amount = 5 };

                await ingredientRepository.AddAsync(ingredient);
                await context.SaveChangesAsync();

                Assert.That(context.Ingredients.Count(), Is.EqualTo(3), message: "AddAsync method works incorrect");
            }

            [Test]
            public async Task IngredientRepository_DeleteByIdAsync_DeletesEntity()
            {
                using var context = new RestaurantDbContext(UnitTestHelper.GetUnitTestDbOptions());

                var ingredientRepository = new IngredientRepository(context);

                await ingredientRepository.DeleteByIdAsync(1);
                await context.SaveChangesAsync();

                Assert.That(context.Ingredients.Count(), Is.EqualTo(1), message: "DeleteByIdAsync works incorrect");
            }

            [Test]
            public async Task IngredientRepository_Update_UpdatesEntity()
            {
                using var context = new RestaurantDbContext(UnitTestHelper.GetUnitTestDbOptions());

                var ingredientRepository = new IngredientRepository(context);
                var ingredient = new Ingredient
                {                    
                    Id = 1,
                    Name = "Beer_Updated",
                    Amount = 23,
                    ExpirationDate = new DateTime(2021, 1, 30),
                    ImportDate = new DateTime(2022, 12, 12),
                    Price = 5,
                    IngredientGroup = IngredientGroup.Drinks
                };

            ingredientRepository.Update(ingredient);
                await context.SaveChangesAsync();

                Assert.That(ingredient, Is.EqualTo(new Ingredient
                {
                    Id = 1,
                    Name = "Beer_Updated",
                    Amount = 23,
                    ExpirationDate = new DateTime(2021, 1, 30),
                    ImportDate = new DateTime(2022, 12, 12),
                    Price = 5,
                    IngredientGroup = IngredientGroup.Drinks
                }).Using(new IngredientEqualityComparer()), message: "Update method works incorrect");
            }

            private static IEnumerable<Ingredient> ExpectedIngredients =>
                new[]
                {
                    new Ingredient { Id = 1, Name = "Water", Amount = 23, ExpirationDate = new DateTime(2021, 1, 30), ImportDate = new DateTime(2022, 12, 12), Price = 5, IngredientGroup = IngredientGroup.Drinks },
                    new Ingredient { Id = 2, Name = "Pork", Amount = 7, ExpirationDate = new DateTime(2022, 4, 30), ImportDate = new DateTime(2011, 12, 30), Price = 150, IngredientGroup = IngredientGroup.Meat }
                };
        }
    
}
