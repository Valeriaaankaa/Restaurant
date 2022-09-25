using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Interfaces
{
    internal interface IPrintable
    {
        void PrintAllDishesInfo(List<Dish> dishes);
        void PrintAllIngredientsInfo(List<Ingredient> ingredients);
        void PrintAllOrdersInfo(List<Order> orders);
        void PrintAllUsersInfo(List<User> users);
    }
}
