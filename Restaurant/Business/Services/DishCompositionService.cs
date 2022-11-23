using AutoMapper;
using Business.Interfaces;
using Business.Models;
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
    public class DishCompositionService : IDishCompositionService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public DishCompositionService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task AddAsync(DishCompositionModel model)
        {
             if (model == null)
             {
                 throw new RestaurantException("Model is null");
             }
             if (model.Amount < 1)
             {
                 throw new RestaurantException("You cannot add Amount < 0");
             }

            var ingredient = await _unitOfWork.IngredientRepository.GetByIdAsync(model.IngredientId);
            var dish = await _unitOfWork.DishRepository.GetByIdAsync(model.DishId);

            DishComposition ddc = new()
            {
                Amount = model.Amount,
                Dish = dish,
                Ingredient = ingredient,
                DishId = model.DishId,
                IngredientId = model.IngredientId
            };

            await _unitOfWork.DishCompositionRepository.AddAsync(ddc);            
            await _unitOfWork.SaveAsync();
        }

        public async Task DeleteAsync(int modelId)
        {
            var composition = await _unitOfWork.DishCompositionRepository.GetByIdAsync(modelId);

            if (composition != null)
            {
                await _unitOfWork.DishCompositionRepository.DeleteByIdAsync(modelId);

                await _unitOfWork.SaveAsync();
            }


        }

        public async Task<IEnumerable<DishCompositionModel>> GetAllAsync()
        {
            var compositions = await _unitOfWork.DishCompositionRepository.GetAllWithDetailsAsync();
            return _mapper.Map<IEnumerable<DishCompositionModel>>(compositions);
        }

        public async Task<DishCompositionModel> GetByIdAsync(int id)
        {
            var composition = await _unitOfWork.DishCompositionRepository.GetByIdAsync(id);
            return _mapper.Map<DishCompositionModel>(composition);
        }

        public async Task UpdateAsync(DishCompositionModel model)
        {
            if (model == null)
            {
                throw new RestaurantException("Model is null");
            }
            if (model.Amount < 1)
            {
                throw new RestaurantException("You cannot set Amount < 0");
            }



            var dc = _mapper.Map<DishComposition>(model);

            var dish = await _unitOfWork.DishRepository.GetByIdAsync(model.DishId);
            var ingredient = await _unitOfWork.IngredientRepository.GetByIdAsync(model.IngredientId);

            dc.Dish = dish;
            dc.Ingredient = ingredient;

            _unitOfWork.DishCompositionRepository.Update(dc);

            await _unitOfWork.SaveAsync();
        }
    }
}
