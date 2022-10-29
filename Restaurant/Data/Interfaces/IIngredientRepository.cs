using Data.Entities;

namespace Data.Interfaces
{
    public interface IIngredientRepository : IRepository<Ingredient>
    {
        Task<IEnumerable<Ingredient>> GetAllWithDetailsAsync();

        Task<Ingredient> GetByIdWithDetailsAsync(int id);
    }
}
