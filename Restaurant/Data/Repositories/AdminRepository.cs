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
    public class AdminRepository : IAdminRepository
    {
        public IRestaurantDbContext _context { get; set; }



        public AdminRepository(IRestaurantDbContext context)
        {
            _context = context;
        }
        public Task AddAsync(Admin entity)
        {
            var res = _context.Admins.AddAsync(entity);
            return res.AsTask();

        }

        public void Delete(Admin entity)
        {
            _context.Admins.Remove(entity);
        }

        public async Task DeleteByIdAsync(int id)
        {
            var res = await _context.Admins.FindAsync(id);
            Delete(res);
        }

        public async Task<IEnumerable<Admin>> GetAllAsync()
        {
            return await _context.Admins.ToListAsync();
        }

        public async Task<Admin> GetByIdAsync(int id)
        {
            return await _context.Admins.FindAsync(id);
        }

        public void Update(Admin entity)
        {
            _context.Admins.Update(entity);
        }
    }
}
