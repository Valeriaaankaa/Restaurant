using Data.Entities;

namespace Data.Interfaces
{
    public interface IDishRepository : IRepository<Dish>
    {

        Task<IEnumerable<Dish>> GetAllWithDetailsAsync();
        Task<Dish> GetByIdWithDetailsAsync(int id);

    }
}
