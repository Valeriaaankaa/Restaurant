using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IUnitOfWork
    {
        IIngredientRepository IngredientRepository { get; }

        IDishRepository DishRepository { get; }

        Task SaveAsync();
    }
}
