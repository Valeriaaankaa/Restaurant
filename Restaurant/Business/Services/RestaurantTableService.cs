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
    public class RestaurantTableService:IRestaurantTableService
    {
        private readonly IUnitOfWork _unitOfWork;
        public RestaurantTableService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        Task ICrud<RestaurantTable>.AddAsync(RestaurantTable model)
        {
            throw new NotImplementedException();
        }

        Task ICrud<RestaurantTable>.DeleteAsync(int modelId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<RestaurantTable>> GetAllAsync()
        {
            var resttables = await _unitOfWork.RestaurantTableRepository.GetAllAsync();
            return resttables;
        }

        Task<RestaurantTable> ICrud<RestaurantTable>.GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task ICrud<RestaurantTable>.UpdateAsync(RestaurantTable model)
        {
            throw new NotImplementedException();
        }
    }
}
