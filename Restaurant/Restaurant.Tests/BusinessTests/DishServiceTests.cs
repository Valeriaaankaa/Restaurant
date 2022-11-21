using NUnit.Framework;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Business.Models;
using Data.Entities;
using Data.Interfaces;
using Moq;
using System.Linq;
using Business.Services;
using Business.Validation;

namespace Restaurant.Tests.BusinessTests
{
    internal class DishServiceTests
    {
        [Test]
        public async Task DishService_GetAll_ReturnsAllProducts()
        {
            //arrange
            var expected = DishModels.ToList();
            var mockUnitOfWork = new Mock<IUnitOfWork>();

            mockUnitOfWork
                .Setup(x => x.DishRepository.GetAllWithDetailsAsync())
                .ReturnsAsync(DishEntities.AsEnumerable());

            var dishService = new DishService(mockUnitOfWork.Object, UnitTestHelper.CreateMapperProfile());

            //act            
            var actual = await dishService.GetAllAsync();

            //assert
            actual.Should ().BeEquivalentTo(expected, options =>
                options.Excluding(x => x.DishCompositions));
        }

        
        [Test]
        public async Task DishService_GetDishCategories_ReturnsAllDistinctCategories()
        {
            //arrange
            var expected = DishCategoriesModels;
            var mockUnitOfWork = new Mock<IUnitOfWork>();

            mockUnitOfWork
                .Setup(x => x.DishRepository.GetAllWithDetailsAsync())
                .ReturnsAsync(DishEntities.AsEnumerable());

            var dishService = new DishService(mockUnitOfWork.Object, UnitTestHelper.CreateMapperProfile());

            //act
            var actual = await dishService.GetDishCategoriesAsync();

            //assert
            actual.Should().BeEquivalentTo(expected);
        }
        
        [TestCase(1)]
        [TestCase(2)]
        public async Task DishService_GetById_ReturnsDishModel(int id)
        {
            //arrange
            var expected = DishModels.FirstOrDefault(x => x.Id == id);

            var mockUnitOfWork = new Mock<IUnitOfWork>();
            mockUnitOfWork
                .Setup(x => x.DishRepository.GetByIdWithDetailsAsync(It.IsAny<int>()))
                .ReturnsAsync(DishEntities.FirstOrDefault(x => x.Id == id));

            var dishService = new DishService(mockUnitOfWork.Object, UnitTestHelper.CreateMapperProfile());

            //act
            var actual = await dishService.GetByIdAsync(1);

            //assert
            actual.Should().BeEquivalentTo(expected, options =>
              options.Excluding(x => x.DishCompositions));
        }

        
        [Test]
        public async Task DishService_AddAsync_AddsDish()
        {
            //arrange
            var mockUnitOfWork = new Mock<IUnitOfWork>();
            mockUnitOfWork.Setup(m => m.DishRepository.AddAsync(It.IsAny<Dish>()));

            var dishService = new DishService(mockUnitOfWork.Object, UnitTestHelper.CreateMapperProfile());
            var dish = new DishModel { Id = 1, Name = "Apple", DishGroup = DishGroup.Desert, Price = 18.00m };

            //act
            await dishService.AddAsync(dish);

            //assert
            mockUnitOfWork.Verify(x => x.DishRepository.AddAsync(It.Is<Dish>(c => c.Id == dish.Id && c.DishGroup == dish.DishGroup && c.Price == dish.Price && c.Name == dish.Name)), Times.Once);
            mockUnitOfWork.Verify(x => x.SaveAsync(), Times.Once);
        }

        
        [Test]
        public async Task DishService_AddAsync_ThrowsMarketExceptionWithEmptyDishName()
        {
            //arrange
            var mockUnitOfWork = new Mock<IUnitOfWork>();
            mockUnitOfWork.Setup(m => m.DishRepository.AddAsync(It.IsAny<Dish>()));

            var dishService = new DishService(mockUnitOfWork.Object, UnitTestHelper.CreateMapperProfile());
            var dish = new DishModel { Id = 1, Name = string.Empty, DishGroup = DishGroup.Desert, Price = 18.00m };

            //act
            Func<Task> act = async () => await dishService.AddAsync(dish);

            //assert
            await act.Should().ThrowAsync<RestaurantException>();
        }

        [TestCase(-5000.50)]
        [TestCase(-500000)]
        [TestCase(-0.0001)]
        public async Task DishService_AddAsync_ThrowsMarketExceptionIfPriceIsNegative(decimal price)
        {
            //arrange
            var mockUnitOfWork = new Mock<IUnitOfWork>();
            mockUnitOfWork.Setup(m => m.DishRepository.AddAsync(It.IsAny<Dish>()));

            var dishService = new DishService(mockUnitOfWork.Object, UnitTestHelper.CreateMapperProfile());
            var dish = new DishModel { Id = 1, Name = "Cola", DishGroup = DishGroup.Desert, Price = price };

            //act
            Func<Task> act = async () => await dishService.AddAsync(dish);

            //assert
            await act.Should().ThrowAsync<RestaurantException>();
        }


        
        [TestCase(1)]
        [TestCase(2)]
        public async Task DishService_DeleteAsync_DeletesDish(int id)
        {
            //arrange
            var mockUnitOfWork = new Mock<IUnitOfWork>();
            mockUnitOfWork.Setup(m => m.DishRepository.DeleteByIdAsync(It.IsAny<int>()));
            var dishService = new DishService(mockUnitOfWork.Object, UnitTestHelper.CreateMapperProfile());

            //act
            await dishService.DeleteAsync(id);

            //assert
            mockUnitOfWork.Verify(x => x.DishRepository.DeleteByIdAsync(id), Times.Once);
            mockUnitOfWork.Verify(x => x.SaveAsync(), Times.Once);
        }
      
        
        
        
        [Test]
        public async Task DishService_UpdateAsync_UpdatesDish()
        {
            //arrange
            var mockUnitOfWork = new Mock<IUnitOfWork>();
            mockUnitOfWork.Setup(m => m.DishRepository.Update(It.IsAny<Dish>()));

            var dishService = new DishService(mockUnitOfWork.Object, UnitTestHelper.CreateMapperProfile());
            var dish = new DishModel { Id = 7, Name = "Queso Cabrales", DishGroup = DishGroup.Desert, Price = 21.00m };

            //act
            await dishService.UpdateAsync(dish);

            //assert
            mockUnitOfWork.Verify(x => x.DishRepository.Update(It.Is<Dish>(c => c.Id == dish.Id && c.DishGroup == dish.DishGroup && c.Price == dish.Price && c.Name == dish.Name)), Times.Once);
            mockUnitOfWork.Verify(x => x.SaveAsync(), Times.Once);
        }

        [Test]
        public async Task DishService_UpdateAsync_ThrowsMarketExceptionsWithEmptyName()
        {
            //arrange
            var mockUnitOfWork = new Mock<IUnitOfWork>();
            mockUnitOfWork.Setup(m => m.DishRepository.Update(It.IsAny<Dish>()));

            var dishService = new DishService(mockUnitOfWork.Object, UnitTestHelper.CreateMapperProfile());
            var dish = new DishModel { Id = 7, Name = "", DishGroup = DishGroup.Desert, Price = 21.00m };

            //act
            Func<Task> act = async () => await dishService.UpdateAsync(dish);

            //assert
            await act.Should().ThrowAsync<RestaurantException>();
        }
        
        
        
        [TestCase(-5000.50)]
        [TestCase(-500000)]
        [TestCase(-0.0001)]
        public async Task DishService_UpdatePrice_ThrowsMarketExceptionsIfPriceIsNegative(decimal price)
        {
            //arrange
            var mockUnitOfWork = new Mock<IUnitOfWork>();
            mockUnitOfWork.Setup(m => m.DishRepository.Update(It.IsAny<Dish>()));

            var dishService = new DishService(mockUnitOfWork.Object, UnitTestHelper.CreateMapperProfile());
            var dish = new DishModel { Id = 77, Price = price };

            //act
            Func<Task> act = async () => await dishService.UpdateAsync(dish);

            //assert
            await act.Should().ThrowAsync<RestaurantException>();
        }

        
        [TestCase(6, new[] { 1, 2 })]
        [TestCase(2, new[] { 3 })]
        [TestCase(0, new[] { 4 })]
        public async Task DishService_GetByFilterAsync_ReturnsProductsByCategory(DishGroup dishGroup, IEnumerable<int> expectedDishIds)
        {
            //arrange
            var expected = DishModels.Where(x => expectedDishIds.Contains(x.Id));
            var filter = new FilterSearchModel { DishGroup = dishGroup };

            var mockUnitOfWork = new Mock<IUnitOfWork>();

            mockUnitOfWork
                .Setup(x => x.DishRepository.GetAllWithDetailsAsync())
                .ReturnsAsync(DishEntities.AsEnumerable());

            var dishService = new DishService(mockUnitOfWork.Object, UnitTestHelper.CreateMapperProfile());

            //act
            var actual = await dishService.GetByFilterAsync(filter);

            //assert
            actual.Should().BeEquivalentTo(expected, options =>
                options.Excluding(x => x.DishCompositions)
            );
        }
        
        [TestCase(20, new[] { 1, 3, 4 })]
        [TestCase(30, new[] { 4 })]
        public async Task DishService_GetByFilter_ReturnsDishByMinPrice(int minPrice, IEnumerable<int> expectedDishIds)
        {
            //arrange
            var expected = DishModels.Where(x => expectedDishIds.Contains(x.Id));
            var filter = new FilterSearchModel { MinPrice = minPrice };

            var mockUnitOfWork = new Mock<IUnitOfWork>();

            mockUnitOfWork
                .Setup(x => x.DishRepository.GetAllWithDetailsAsync())
                .ReturnsAsync(DishEntities.AsEnumerable());

            var dishService = new DishService(mockUnitOfWork.Object, UnitTestHelper.CreateMapperProfile());

            //act
            var actual = await dishService.GetByFilterAsync(filter);

            //assert
            actual.Should().BeEquivalentTo(expected, options =>
                options.Excluding(x => x.DishCompositions)
            );
        }

        [TestCase(2, 16, null, new[] { 3 })]
        [TestCase(6, 10, 28, new[] { 1, 2 })]

        public async Task DishService_GetByFilter_ReturnsDishByFilter(int? categoryId, int? minPrice, int? maxPrice, IEnumerable<int> expectedDishIds)
        {
            //arrange
            var expected = DishModels.Where(x => expectedDishIds.Contains(x.Id)).ToList();
            var filter = new FilterSearchModel { DishGroup = (DishGroup) categoryId, MinPrice = minPrice, MaxPrice = maxPrice };

            var mockUnitOfWork = new Mock<IUnitOfWork>();

            mockUnitOfWork
                .Setup(x => x.DishRepository.GetAllWithDetailsAsync())
                .ReturnsAsync(DishEntities.AsEnumerable());

            var productService = new DishService(mockUnitOfWork.Object, UnitTestHelper.CreateMapperProfile());

            //act
            var actual = await productService.GetByFilterAsync(filter);

            //assert
            actual.Should().BeEquivalentTo(expected, options => options.Excluding(x => x.DishCompositions)
            );
        }

        
       
        private static IEnumerable<Dish> DishEntities =>
            new List<Dish>
            {
                new Dish
                {
                    Id = 1, Name = "Cola", DishGroup = DishGroup.Alcohol, Price = 25
                },
                new Dish
                {
                    Id = 2, Name = "Pepsi", DishGroup = DishGroup.Alcohol, Price = 15
                },
                new Dish
                {
                    Id = 3, Name = "Fry potato", DishGroup = DishGroup.Desert, Price = 26
                },
                new Dish
                {
                    Id = 4, Name = "Rice", DishGroup = DishGroup.FirstDish, Price = 66
                },
            };

        private static IEnumerable<DishModel> DishModels =>
            new List<DishModel>
            {
                new DishModel { Id = 1, Name = "Cola", DishGroup = DishGroup.Alcohol , Price = 25},
                new DishModel { Id = 2, Name = "Pepsi", DishGroup = DishGroup.Alcohol, Price = 15 },
                new DishModel { Id = 3, Name = "Fry potato", DishGroup = DishGroup.Desert, Price = 26 },
                new DishModel { Id = 4, Name = "Rice", DishGroup = DishGroup.FirstDish, Price = 66}
            };

        private static IEnumerable<DishGroup> DishCategoriesModels =>
            new List<DishGroup>
            {
                DishGroup.Alcohol, DishGroup.Desert, DishGroup.FirstDish
            };

    }
}
