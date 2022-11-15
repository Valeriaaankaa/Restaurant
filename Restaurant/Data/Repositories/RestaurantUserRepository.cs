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
    public class RestaurantUserRepository : IRestaurantUserRepository
    {
        public IRestaurantDbContext _context { get; set; }



        public RestaurantUserRepository(IRestaurantDbContext context)
        {
            _context = context;
        }
        public Task AddAsync(Customer entity)
        {
            var res = _context.RestaurantUsers.AddAsync(entity);
            return res.AsTask();

        }

        public void Delete(Customer entity)
        {
            _context.RestaurantUsers.Remove(entity);
        }

        public async Task DeleteByIdAsync(int id)
        {
            var res = await _context.RestaurantUsers.FindAsync(id);
            Delete(res);
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            return await _context.RestaurantUsers.ToListAsync();
        }

        public async Task<Customer> GetByIdAsync(int id)
        {
            return await _context.RestaurantUsers.FindAsync(id);
        }

        public void Update(Customer entity)
        {
            _context.RestaurantUsers.Update(entity);
        }
    }
}
