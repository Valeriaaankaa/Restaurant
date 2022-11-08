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
    public class TableOrderRepository : ITableOrderRepository
    {
        public IRestaurantDbContext _context { get; set; }



        public TableOrderRepository(IRestaurantDbContext context)
        {
            _context = context;
        }
        public Task AddAsync(TableOrder entity)
        {
            var res = _context.TableOrders.AddAsync(entity);
            return res.AsTask();

        }

        public void Delete(TableOrder entity)
        {
            _context.TableOrders.Remove(entity);
        }

        public async Task DeleteByIdAsync(int id)
        {
            var res = await _context.TableOrders.FindAsync(id);
            Delete(res);
        }

        public async Task<IEnumerable<TableOrder>> GetAllAsync()
        {
            return await _context.TableOrders.ToListAsync();
        }

        public async Task<TableOrder> GetByIdAsync(int id)
        {
            return await _context.TableOrders.FindAsync(id);
        }

        public void Update(TableOrder entity)
        {
            _context.TableOrders.Update(entity);
        }
    }
}
