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
    public class PersonRepository : IPersonRepository
    {
        public IRestaurantDbContext _context { get; set; }



        public PersonRepository(IRestaurantDbContext context)
        {
            _context = context;
        }
        public Task AddAsync(Person entity)
        {
            var res = _context.People.AddAsync(entity);
            return res.AsTask();

        }

        public void Delete(Person entity)
        {
            _context.People.Remove(entity);
        }

        public async Task DeleteByIdAsync(int id)
        {
            var res = await _context.People.FindAsync(id);
            Delete(res);
        }

        public async Task<IEnumerable<Person>> GetAllAsync()
        {
            return await _context.People.ToListAsync();
        }

        public async Task<Person> GetByIdAsync(int id)
        {
            return await _context.People.FindAsync(id);
        }

        public void Update(Person entity)
        {
            _context.People.Update(entity);
        }
    }
}
