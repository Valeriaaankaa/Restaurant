using Data.Entities;

namespace Data.Interfaces
{
    public interface IOrderRepository : IRepository<Order>
    {
        IQueryable<Order> Orders { get;}
        void SaveOrder(Order order);
    }
}
