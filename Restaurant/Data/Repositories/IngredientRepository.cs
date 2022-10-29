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
    public class IngredientRepository : IIngredientRepository
    {
        public IRestaurantDbContext _context { get; set; }



        public IngredientRepository(IRestaurantDbContext context)
        {
            _context = context;
        }
        public Task AddAsync(Ingredient entity)
        {
            var res = _context.Ingredients.AddAsync(entity);
            return res.AsTask();

        }

        public void Delete(Ingredient entity)
        {
            _context.Ingredients.Remove(entity);
        }

        public async Task DeleteByIdAsync(int id)
        {
            var res = await _context.Ingredients.FindAsync(id);
            Delete(res);
        }

        public async Task<IEnumerable<Ingredient>> GetAllAsync()
        {
            return await _context.Ingredients.ToListAsync();
        }

        public async Task<Ingredient> GetByIdAsync(int id)
        {
            return await _context.Ingredients.FindAsync(id);
        }

        public void Update(Ingredient entity)
        {
            _context.Ingredients.Update(entity);
        }
    }
}
