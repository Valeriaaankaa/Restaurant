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

            await _unitOfWork.DishCompositionRepository.AddAsync(_mapper.Map<DishComposition>(model));
            await _unitOfWork.SaveAsync();
        }

        public async Task DeleteAsync(int modelId)
        {
            await _unitOfWork.DishCompositionRepository.DeleteByIdAsync(modelId);

            await _unitOfWork.SaveAsync();
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

            _unitOfWork.DishCompositionRepository.Update(dc);

            await _unitOfWork.SaveAsync();
        }
    }
}
