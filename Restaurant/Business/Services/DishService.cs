using Business.Interfaces;
using Data.Entities;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public Task AddAsync(Dish model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int modelId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Dish>> GetAllAsync()
        {
            var dishes = await _unitOfWork.DishRepository.GetAllAsync();
            return dishes;
        }

        public Task<Dish> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Dish model)
        {
            throw new NotImplementedException();
        }
    }
}
