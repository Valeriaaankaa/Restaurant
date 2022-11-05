using Data.Data;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class RestaurantTableRepository : IRestaurantTableRepository
    {
        public IRestaurantDbContext _context { get; set; }



        public RestaurantTableRepository(IRestaurantDbContext context)
        {
            _context = context;
        }
        public Task AddAsync(RestaurantTable entity)
        {
            var res = _context.RestaurantTables.AddAsync(entity);
            return res.AsTask();

        }

        public void Delete(RestaurantTable entity)
        {
            _context.RestaurantTables.Remove(entity);
        }

        public async Task DeleteByIdAsync(int id)
        {
            var res = await _context.RestaurantTables.FindAsync(id);
            Delete(res);
        }

        public async Task<IEnumerable<RestaurantTable>> GetAllAsync()
        {
            return await _context.RestaurantTables.ToListAsync();
        }

        public async Task<RestaurantTable> GetByIdAsync(int id)
        {
            return await _context.RestaurantTables.FindAsync(id);
        }

        public void Update(RestaurantTable entity)
        {
            _context.RestaurantTables.Update(entity);
        }
    }
}
