using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Interfaces
{
    internal interface IPrintable
    {
        void PrintAllDishesInfo(IEnumerable<Dish> dishes);
        void PrintAllIngredientsInfo(IEnumerable<Ingredient> ingredients);
        void PrintAllOrdersInfo(IEnumerable<Order> orders);
        void PrintAllUsersInfo(IEnumerable<RestaurantUser> restaurantUser);
    }
}
