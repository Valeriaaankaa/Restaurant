using Data.Interfaces;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private RestaurantDbContext _context;
        private IngredientRepository _ingredients;
        private DishRepository _dishes;

        public UnitOfWork(RestaurantDbContext context)
        {
            _context = context;
        }

        public IIngredientRepository IngredientRepository
        {
            get
            {
                return _ingredients ??= new IngredientRepository(_context);
            }
        }

        public IDishRepository DishRepository
        {
            get
            {
                return _dishes ??= new DishRepository(_context);
            }
        }
        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

    }
}
