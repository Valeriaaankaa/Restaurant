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
    public class OrderService : IOrderService
    {
        private readonly IUnitOfWork _unitOfWork;
        public OrderService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddAsync(Order model)
        {
            if (model == null)
            {
                throw new RestaurantException("Order model is null");
            }
            if (model.OrderDate < DateTime.Now)
            {
                throw new RestaurantException("You cannot order in the past");
            }
            if (String.IsNullOrEmpty(model.Address))
            {
                throw new RestaurantException("Order Address is empty");
            }

            await _unitOfWork.OrderRepository.AddAsync(model);
            await _unitOfWork.SaveAsync();
        }

        public async Task DeleteAsync(int modelId)
        {
            var order = await _unitOfWork.OrderRepository.GetByIdAsync(modelId);

            if (order != null)
            {
                await _unitOfWork.OrderRepository.DeleteByIdAsync(modelId);

                await _unitOfWork.SaveAsync();
            }
        }

        public async Task<IEnumerable<Order>> GetAllAsync()
        {
            var orders = await _unitOfWork.OrderRepository.GetAllAsync();
            return orders;
        }

        public async Task<Order> GetByIdAsync(int id)
        {
            var order = await _unitOfWork.OrderRepository.GetByIdAsync(id);
            return order;
        }

        public async Task UpdateAsync(Order model)
        {
            if (model == null)
            {
                throw new RestaurantException("Order Model is null");
            }
            if (String.IsNullOrEmpty(model.Address))
            {
                throw new RestaurantException("Address in order is empty");
            }

            var dish = model;

            _unitOfWork.OrderRepository.Update(dish);

            await _unitOfWork.SaveAsync();
        }
    }
}
