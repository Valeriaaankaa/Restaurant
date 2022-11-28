using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IUnitOfWork
    {
        IDishCompositionRepository DishCompositionRepository { get; }
        IDishOrderRepository DishOrderRepository { get; }  
        IOrderRepository OrderRepository { get; }
        IRestaurantTableRepository RestaurantTableRepository { get; }
        ITableOrderRepository TableOrderRepository { get; }
        IIngredientRepository IngredientRepository { get; }
        IDishRepository DishRepository { get; }
        IUserRepository UserRepository { get; }
        IRoleRepository RoleRepository { get; }

        Task SaveAsync();
    }
}
