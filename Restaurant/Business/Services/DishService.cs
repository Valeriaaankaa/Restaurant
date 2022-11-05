using Business.Interfaces;
using Business.Validation;
using Data.Entities;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class DishService : IDishService
    {
        private readonly IUnitOfWork _unitOfWork;
        public DishService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddAsync(Dish model)
        {
            if (model == null)
            {
                throw new RestaurantException("Model is null");
            }
            if (model.Price < 0)
            {
                throw new RestaurantException("Price is negative");
            }
            if (model.Name == null || model.Name == "")
            {
                throw new RestaurantException("Name is empty");
            }

            await _unitOfWork.DishRepository.AddAsync(model);
            await _unitOfWork.SaveAsync();
        }

        public async Task DeleteAsync(int modelId)
        {
            await _unitOfWork.DishRepository.DeleteByIdAsync(modelId);

            await _unitOfWork.SaveAsync();
        }

        public async Task<IEnumerable<Dish>> GetAllAsync()
        {
            var dishes = await _unitOfWork.DishRepository.GetAllAsync();
            return dishes;
        }

        public async Task<Dish> GetByIdAsync(int id)
        {
            var dish = await _unitOfWork.DishRepository.GetByIdAsync(id);
            return dish;
        }

        public async Task UpdateAsync(Dish model)
        {
            if (model == null)
            {
                throw new RestaurantException("Model is null");
            }
            if (model.Name == null || model.Name == "")
            {
                throw new RestaurantException("Name is empty");
            }

            var dish = model;

            _unitOfWork.DishRepository.Update(dish);

            await _unitOfWork.SaveAsync();
        }
    }
}
