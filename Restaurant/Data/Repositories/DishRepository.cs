using Data.Data;
using Data.Entities;
using Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories
{
    internal class DishRepository : IDishRepository    {
        public IRestaurantDbContext _context { get; set; }
        public DishRepository(IRestaurantDbContext context)
        {
            _context = context;
        }
        public Task AddAsync(Dish entity)
        {
            var res = _context.Dishes.AddAsync(entity);
            return res.AsTask();

        }

        public void Delete(Dish entity)
        {
            _context.Dishes.Remove(entity);
        }

        public async Task DeleteByIdAsync(int id)
        {
            var res = await _context.Dishes.FindAsync(id);
            Delete(res);
        }

        public async Task<IEnumerable<Dish>> GetAllAsync()
        {
            return await _context.Dishes.ToListAsync();
        }

        public async Task<Dish> GetByIdAsync(int id)
        {
            return await _context.Dishes.FindAsync(id);
        }

        public void Update(Dish entity)
        {
            _context.Dishes.Update(entity);
        }
    }
}
