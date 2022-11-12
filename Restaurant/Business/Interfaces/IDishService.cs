using Business.Models;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IDishService : ICrud<DishModel>
    {
        Task<IEnumerable<DishModel>> GetByFilterAsync(FilterSearchModel filterSearch);
        Task<IEnumerable<DishGroup>> GetDishCategoriesAsync();
        IEnumerable<DishModel> Sort(IEnumerable<DishModel> dm, string Category, SortType st);


    }
}
