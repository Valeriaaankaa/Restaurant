using System;
using System.Linq;
using System.Collections;
using static Restaurant.Presentation.DelegateModel;
using Microsoft.VisualBasic;

namespace Restaurant.Presentation
{
    public class UserMenu : ICollection<Dish>
    {
        readonly DelegateMenu m = new DelegateMenu();
        private List <RestaurantUser> Users;
        private List<Ingredient> Ingredients;
        private List<Dish> Dishes;
        private List<Order> Orders;

        public Dish Current => throw new NotImplementedException();

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public UserMenu()
        {
            Users = new();
            Dishes = new();
            Ingredients = new();
            Orders = new();
        }
        public Dish this[int index]
        {
            get => Dishes[index];
            set => Dishes[index] = value;
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
            m.Add("4: Print Dish", PrintDish);
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

        private void PrintDish()
        {
            var dish = new Dish();
            dish.Print();
        }

        //Ingredient UI functions
        private void IngredientOptions()
        {
            m.Remove();
            m.Add("1: Create Ingredient", CreateIngredient);
            m.Add("2: Update Ingredient", UpdateIngredient);
            m.Add("3: Delete Ingredient", DeleteIngredient);
            m.Add("4: Print Ingredient", PrintIngredient);
            m.Show();
            m.GetChoice();
            GoBack();
        }
        private void CreateIngredient()
        {
            var ingredient = new Ingredient();
            ingredient.CreateObject();
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

        private void PrintIngredient()
        {
            var ingredient = new Ingredient();
            ingredient.Print();
        }

        //Order UI functions
        private void OrderOptions()
        {
            m.Remove();
            m.Add("4: Print User", PrintOrder);
            m.Show();
            m.GetChoice();
            GoBack();
        }

        private void PrintOrder()
        {
            var order = new Order();
            order.Print();
        }

        //User UI functions
        private void UserOptions()
        {
            m.Remove();
            m.Add("1: Create User", CreateUser);
            m.Add("2: Update User", UpdateUser);
            m.Add("3: Delete User", DeleteUser);
            m.Add("4: Print User", PrintUser);
            m.Show();
            m.GetChoice();
            GoBack();
        }

        private void CreateUser()
        {
            var user = new RestaurantUser();
            user.CreateObject();
            Users.Add(user);
        }

        private void UpdateUser()
        {
            var user = new RestaurantUser();
            user.UpdateObject(Users);
        }

        private void DeleteUser()
        {
            var user = new RestaurantUser();
            user.DeleteObject(Users);
        }

        private void PrintUser()
        {
            var user = new RestaurantUser();
            user.Print();
        }

        public IEnumerator<Dish> GetEnumerator()
        {
            return Dishes.GetEnumerator();
        }
        public bool MoveNext()
        {
            return GetEnumerator().MoveNext();
        }
        public void Dispose()
        {
            Dishes.GetEnumerator().Dispose();
        }
        public void Add(Dish item)
        {
            Dishes.Add(item);
        }
        public void Clear()
        {
            Dishes.Clear();
        }
        public bool Contains(Dish item)
        {
            return Dishes.Contains(item);
        }
        public void CopyTo(Dish[] array, int arrayIndex)
        {
            Dishes.CopyTo(array, arrayIndex);
        }
        public bool Remove(Dish item)
        {
            return Dishes.Remove(item);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return Dishes.GetEnumerator();
        }
    }
}
