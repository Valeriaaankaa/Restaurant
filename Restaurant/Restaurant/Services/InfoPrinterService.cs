using Restaurant.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Services
{
    internal class InfoPrinterService : IPrintable
    {
        public void PrintAllDishesInfo(List<Dish> dishes)
        {
            if (dishes.Count != 0)
            {
                foreach (var dish in dishes)
                {
                    Console.WriteLine($"Dishes: \n" + $"Name: {dish.Name}\n" +
                                   $"Cost: {dish.Price}\n" + $"DishGroup: {dish.DishGroup}\n" +
                                   $"Description: {dish.Description}\n");
                }
            }
            else
            {
                Console.WriteLine("There aren't dishes in the list");
            }
        }

        public void PrintAllIngredientsInfo(List<Ingredient> ingredients)
        {
            if (ingredients.Count != 0)
            {
                foreach (var ingredient in ingredients)
                {
                    Console.WriteLine($"Ingredients: \n" + $"Name: {ingredient.Name}\n" +
                                    $"Cost: {ingredient.Price}\n" + $"IngredientAmount: {ingredient.Amount}\n" +
                                    $"ImportDate: {ingredient.ImportDate}\n" + $"ExpirationDate: {ingredient.ExpirationDate}\n");
                }
            }
            else
            {
                Console.WriteLine("There aren't ingredients in the list");
            }
        }

        public void PrintAllOrdersInfo(List<Order> orders)
        {
            if (orders.Count != 0)
            {
                foreach (var order in orders)
                {
                    Console.WriteLine($"Orders: \n" + $"OrderDate: {order.OrderDate.ToString()}\n" +
                                    $"Address: {order.Address}\n" + "UserOrder Information:" + $"{order.RestaurantUser.ToString()}\n" +
                                    $"OrderStatus: {order.OrderStatus.ToString()}\n");
                }
            }
            else
            {
                Console.WriteLine("There aren't orders in the list");
            }
        }

        public void PrintAllUsersInfo(List<RestaurantUser> restaurantUser)
        {
            if (restaurantUser.Count != 0)
            {
                foreach (var user in restaurantUser)
                {
                    Console.WriteLine($"Users: \n" + $"Name: {user.Name}\n" + $"Surname: {user.Surname}\n"
                  + $"UserLogin: {user.Login}\n" + $"UserEmail: {user.Email}\n" + $"UserPassword: {user.Password}\n"
                  + $"BirthDay: {user.BirthDay.ToString()}\n" + $"PhoneNumber: {user.PhoneNumber}\n" + $"Role: {user.Role.ToString()}\n");
                }
            }

            else
            {
                Console.WriteLine("There aren't restaurant users in the list");
            }
        }
    }
}
