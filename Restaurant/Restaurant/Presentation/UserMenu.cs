using System;
using System.Linq;
using System.Collections;
using static Restaurant.Presentation.DelegateModel;
using Microsoft.VisualBasic;
using Restaurant.Services;

namespace Restaurant.Presentation
{
    public class UserMenu
    {
        readonly DelegateMenu m = new DelegateMenu();
        private List <RestaurantUser> RestaurantUsers;
        private List<Ingredient> Ingredients;
        private List<Dish> Dishes;
        private List<Order> Orders;
        private InfoPrinterService _infoPrinterService;
        public UserMenu()
        {
            RestaurantUsers = new();
            Dishes = new();
            Ingredients = new();
            Orders = new();
            _infoPrinterService = new();
        }

        public void Run() => ShowAvailableOperation();

        private void ShowAvailableOperation()
        {     
            m.Add("1: Dish Menu", DishOptions);
            m.Add("2: Ingredient Menu", IngredientOptions);
            m.Add("3: Order Menu", OrderOptions);
            m.Add("4: User Menu", UserOptions);
            m.Show();
            m.GetChoice();
        }

        private void GoBack()
        {
            Console.WriteLine("Press any button to go back");
            Console.ReadKey();
            Console.Clear();
            m.Remove();
            m.RunStartMenu(ShowAvailableOperation);
        }

       
        //Dish UI functions
        private void DishOptions()
        {
            m.Remove();
            m.Add("1: Create Dish", CreateDish);
            m.Add("2: Update Dish", UpdateDish);
            m.Add("3: Delete Dish", DeleteDish);
            m.Add("4: Print all Dishes info", PrintDishesInfo);
            m.Show();
            m.GetChoice();
            GoBack();
        }

        private void CreateDish()
        {
            var dish = new Dish();
            //dish.CreateObject();
            //Dishes.Add(dish);
        }

        private void UpdateDish()
        {
            var dish = new Dish();
            //dish.UpdateObject(Dishes);
        }

        private void DeleteDish()
        {
            var dish = new Dish();
            dish.DeleteObject(Dishes);
        }

        private void PrintDishesInfo()
        {
            _infoPrinterService.PrintAllDishesInfo(Dishes);
        }

        //Ingredient UI functions
        private void IngredientOptions()
        {
            m.Remove();
            m.Add("1: Create Ingredient", CreateIngredient);
            m.Add("2: Update Ingredient", UpdateIngredient);
            m.Add("3: Delete Ingredient", DeleteIngredient);
            m.Add("4: Print all Ingredients", PrintIngredientsInfo);
            m.Show();
            m.GetChoice();
            GoBack();
        }
        private void CreateIngredient()
        {
            var ingredient = new Ingredient();
            ingredient = ingredient.CreateObject();
            Ingredients.Add(ingredient);

           
        }

        private void UpdateIngredient()
        {
            var ingredient = new Ingredient();
            ingredient.UpdateObject(Ingredients);
        }

        private void DeleteIngredient()
        {
            var ingredient = new Ingredient();
            ingredient.DeleteObject(Ingredients);
        }

        private void PrintIngredientsInfo()
        {
            _infoPrinterService.PrintAllIngredientsInfo(Ingredients);
        }

        //Order UI functions
        private void OrderOptions()
        {
            m.Remove();
            m.Add("1: Print all Orders info", PrintOrdersInfo);
            m.Show();
            m.GetChoice();
            GoBack();
        }

        private void PrintOrdersInfo()
        {;
            _infoPrinterService.PrintAllOrdersInfo(Orders);
        }

        //User UI functions
        private void UserOptions()
        {
            m.Remove();
            m.Add("1: Create User", CreateUser);
            m.Add("2: Update User", UpdateUser);
            m.Add("3: Delete User", DeleteUser);
            m.Add("4: Print all Users info", PrintUsersInfo);
            m.Show();
            m.GetChoice();
            GoBack();
        }

        private void CreateUser()
        {
            var user = new RestaurantUser();
            user = user.CreateObject();
            RestaurantUsers.Add(user);
        }

        private void UpdateUser()
        {
            var user = new RestaurantUser();
            user.UpdateObject(RestaurantUsers);
        }

        private void DeleteUser()
        {
            var user = new RestaurantUser();
            user.DeleteObject(RestaurantUsers);
        }

        private void PrintUsersInfo()
        {           
            _infoPrinterService.PrintAllUsersInfo(RestaurantUsers);
        }
    }
}
