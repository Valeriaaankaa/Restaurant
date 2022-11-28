
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
        private UserDbContext _identitycontext;
        private DishCompositionRepository _dishCompositions;
        private DishOrderRepository _dishOrders;
        private DishRepository _dishes;
        private IngredientRepository _ingredients;
        private OrderRepository _orders;
        private RestaurantTableRepository _restaurantTables;
        private TableOrderRepository _tableOrders;
        private UserRepository _users;
        private RoleRepository _roles;


        public UnitOfWork(RestaurantDbContext context, UserDbContext identitycontext)
        {
            _context = context;
            _identitycontext = identitycontext;
        }


        public IUserRepository UserRepository
        {
            get
            {
                return _users ??= new UserRepository(_identitycontext);
            }
        }

        public IRoleRepository RoleRepository
        {
            get
            {
                return _roles ??= new RoleRepository(_identitycontext);
            }
        }






        public IDishCompositionRepository DishCompositionRepository
        {
            get
            {
                return _dishCompositions ??= new DishCompositionRepository(_context);
            }
        }

        public IDishOrderRepository DishOrderRepository
        {
            get
            {
                return _dishOrders ??= new DishOrderRepository(_context);
            }
        }

        public IDishRepository DishRepository
        {
            get
            {
                return _dishes ??= new DishRepository(_context);
            }
        }
        public IIngredientRepository IngredientRepository
        {
            get
            {
                return _ingredients ??= new IngredientRepository(_context);
            }
        }

        public IOrderRepository OrderRepository
        {
            get
            {
                return _orders ??= new OrderRepository(_context);
            }
        }
        public IRestaurantTableRepository RestaurantTableRepository
        {
            get
            {
                return _restaurantTables ??= new RestaurantTableRepository(_context);
            }
        }

        
        public ITableOrderRepository TableOrderRepository
        {
            get
            {
                return _tableOrders ??= new TableOrderRepository(_context);
            }
        }


        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

    }
}
