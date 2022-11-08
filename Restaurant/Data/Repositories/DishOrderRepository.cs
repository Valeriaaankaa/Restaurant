using Data.Data;
using Data.Entities;
using Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class DishOrderRepository : IDishOrderRepository
    {
        public IRestaurantDbContext _context { get; set; }



        public DishOrderRepository(IRestaurantDbContext context)
        {
            _context = context;
        }
        public Task AddAsync(DishOrder entity)
        {
            var res = _context.DishOrders.AddAsync(entity);
            return res.AsTask();

        }

        public void Delete(DishOrder entity)
        {
            _context.DishOrders.Remove(entity);
        }

        public async Task DeleteByIdAsync(int id)
        {
            var res = await _context.DishOrders.FindAsync(id);
            Delete(res);
        }

        public async Task<IEnumerable<DishOrder>> GetAllAsync()
        {
            return await _context.DishOrders.ToListAsync();
        }

        public async Task<DishOrder> GetByIdAsync(int id)
        {
            return await _context.DishOrders.FindAsync(id);
        }

        public void Update(DishOrder entity)
        {
            _context.DishOrders.Update(entity);
        }
    }
}
