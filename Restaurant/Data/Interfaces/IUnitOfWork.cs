using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IUnitOfWork
    { 
        IAdminRepository AdminRepository { get; }
        IDishCompositionRepository DishCompositionRepository { get; }
        IDishOrderRepository DishOrderRepository { get; }  
        IOrderRepository OrderRepository { get; }
        IRestaurantTableRepository RestaurantTableRepository { get; }
        IRestaurantUserRepository RestaurantUserRepository { get; }
        ITableOrderRepository TableOrderRepository { get; }
        IIngredientRepository IngredientRepository { get; }
        IDishRepository DishRepository { get; }
        Task SaveAsync();
    }
}
