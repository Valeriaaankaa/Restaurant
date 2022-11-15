using Data.Entities;

namespace Data.Interfaces
{
    public interface IDishCompositionRepository : IRepository<DishComposition>
    {
        Task<IEnumerable<DishComposition>> GetAllWithDetailsAsync();
        Task<DishComposition> GetByIdWithDetailsAsync(int id);
    }
}
