using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Interfaces
{
    internal interface IPrintable
    {
        void PrintAllOrdersInfo(Dictionary<int, List<Order>> orders);

        void PrintAllIngredientsInfo(IEnumerable<Ingredient> ingredients);

        void PrintAllDishesInfo(IEnumerable<Dish> dishes);

        void PrintAllUsersInfo(IEnumerable<RestaurantUser> restaurantUser);
    }
}
