using Business.Interfaces;
using Business.Validation;
using Data.Entities;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class IngredientService : IIngredientService
    {
        private readonly IUnitOfWork _unitOfWork;
        public IngredientService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddAsync(Ingredient model)
        {
            if (model == null)
            {
                throw new RestaurantException("Ingredient model is null");
            }
            if (String.IsNullOrEmpty(model.Name))
            {
                throw new RestaurantException("Ingredient Name is empty");
            }
          
            await _unitOfWork.IngredientRepository.AddAsync(model);
            await _unitOfWork.SaveAsync();
        }

        public async Task DeleteAsync(int modelId)
        {
            var ingredient = await _unitOfWork.IngredientRepository.GetByIdAsync(modelId);

            if (ingredient != null)
            {
                await _unitOfWork.IngredientRepository.DeleteByIdAsync(modelId);

                await _unitOfWork.SaveAsync();
            }
        }

        public async Task<IEnumerable<Ingredient>> GetAllAsync()
        {
            var ingredients = await _unitOfWork.IngredientRepository.GetAllAsync();
            return ingredients;
        }

        public async Task<Ingredient> GetByIdAsync(int id)
        {
            var ingredient = await _unitOfWork.IngredientRepository.GetByIdAsync(id);
            return ingredient;
        }

        public async Task UpdateAsync(Ingredient model)
        {
            if (model == null)
            {
                throw new RestaurantException("Ingredient Model is null");
            }
            if (String.IsNullOrEmpty(model.Name))
            {
                throw new RestaurantException("Ingredient Name is empty");
            }

            var ingredient = model;

            _unitOfWork.IngredientRepository.Update(ingredient);

            await _unitOfWork.SaveAsync();
        }
    }
}
