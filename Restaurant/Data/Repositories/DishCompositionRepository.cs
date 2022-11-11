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
    public class DishCompositionRepository : IDishCompositionRepository
    {
        public IRestaurantDbContext _context { get; set; }



        public DishCompositionRepository(IRestaurantDbContext context)
        {
            _context = context;
        }
        public Task AddAsync(DishComposition entity)
        {
            var res = _context.DishCompositions.AddAsync(entity);
            return res.AsTask();

        }

        public void Delete(DishComposition entity)
        {
            _context.DishCompositions.Remove(entity);
        }

        public async Task DeleteByIdAsync(int id)
        {
            var res = await _context.DishCompositions.FindAsync(id);
            Delete(res);
        }

        public async Task<IEnumerable<DishComposition>> GetAllAsync()
        {
            return await _context.DishCompositions.ToListAsync();
        }

        public async Task<DishComposition> GetByIdAsync(int id)
        {
            return await _context.DishCompositions.FindAsync(id);
        }

        public void Update(DishComposition entity)
        {
            _context.DishCompositions.Update(entity);
        }
    }
}
