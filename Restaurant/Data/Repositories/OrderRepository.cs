using Data.Data;
using Data.Entities;
using Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;


namespace Data.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public IRestaurantDbContext _context { get; set; }

        public IQueryable<Order> Orders => _context.Orders
            .Include(o => o.DishesOrder ?? new List<DishOrder>())
            .ThenInclude(l => l.Dish);

        public OrderRepository(RestaurantDbContext context)
        {
            _context = context;
        }
        public Task AddAsync(Order entity)
        {
            var res = _context.Orders.AddAsync(entity);
            return res.AsTask();

        }

        public void Delete(Order entity)
        {
            _context.Orders.Remove(entity);
        }

        public async Task DeleteByIdAsync(int id)
        {
            var res = await _context.Orders.FindAsync(id);
            Delete(res);
        }

        public async Task<IEnumerable<Order>> GetAllAsync()
        {
            return await _context.Orders.ToListAsync();
        }

        public async Task<Order> GetByIdAsync(int id)
        {
            return await _context.Orders.FindAsync(id);
        }

        public void Update(Order entity)
        {
            _context.Orders.Update(entity);
        }
        public void SaveOrder(Order order)
        {
            (_context as RestaurantDbContext)?.AttachRange(order.DishesOrder.Select(d => d.Dish));
            if (order.Id == 0)
                _context.Orders.Add(order);
            (_context as RestaurantDbContext)?.SaveChangesAsync();

        }
    }
}
