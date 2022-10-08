using System;
using System.Linq;
using System.Collections;
using static Restaurant.Presentation.DelegateModel;
using Microsoft.VisualBasic;
using Restaurant.Services;

namespace Restaurant.Presentation
{
    public class UserMenu : ICollection<Dish>
    {
        readonly DelegateMenu m = new DelegateMenu();
        private List <RestaurantUser> RestaurantUsers;
        private List<Ingredient> Ingredients;
        private List<Dish> Dishes;


        private Dictionary<int, List<Order>> Orders;
        private Dictionary<string, List<Ingredient>> DishIngredients;

        public Dish Current => throw new NotImplementedException();

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();
        private InfoPrinterService _infoPrinterService;

        public UserMenu()
        {
            RestaurantUsers = new();
            Dishes = new();
            Ingredients = new();
            Orders = new();
            _infoPrinterService = new();
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
            m.Add("4: Print all Dishes info", PrintDishesInfo);
            m.Show();
            m.GetChoice();
            GoBack();
        }

        private void CreateDish()
        {
            string Name, Description;
            decimal Price;
            int group;

            Console.Write("Enter the name of the new dish: ");
            Name=Console.ReadLine();
            Console.Write("Enter dish description of the new dish: ");
            Description = Console.ReadLine();
            Console.Write("Enter dish price of the new dish: ");
            Price = Convert.ToDecimal(Console.ReadLine());  
            Console.Write("Choose group dish");
            group = Convert.ToInt32(Console.ReadLine());     

            var dish = new Dish(Name, Description, Price, group);
            Dishes.Add(dish);
        }

        private void UpdateDish()
        {         

            string Name, Description;
            decimal Price;
            int category;

            Console.Write("Enter dish name: ");
            Name = Console.ReadLine(); 
            Console.Write("Write dish price: ");
            Price = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Write dish description");
            Description = Console.ReadLine();
            Console.Write("Write dish category");
            category = Convert.ToInt32(Console.ReadLine());

            var dish = new Dish();
            var updatedish = new Dish (Name, Description,Price ,category);

            bool result =  dish.UpdateObject(Dishes, updatedish);

            if(result)
            {
                Console.Write("Dish Updated");
            }
            else
            {
                Console.Write("Dish Not Found");
            }


        }

        private void DeleteDish()
        {
            Console.Write("Enter the name of the ingredient you want to delete:");
            string ingrname = Console.ReadLine();

            var dish = new Dish();
            dish.DeleteObject(Dishes, ingrname);
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
            string Name;
            decimal Price, Amount;
            int dayimp, monthimp, yearimp, dayexp, monthexp, yearexp;
            DateTime ImportDate, ExpirationDate;

            Console.Write("Enter the name of the new ingredient: ");
            Name = Console.ReadLine();
            Console.Write("Enter ingredient price of the new ingredient: ");
            Price = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter ingredient amoubt of the new ingredient: ");
            Amount = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Write day of Import:");
            dayimp = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write month of Import:");
            monthimp = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write year of Import:");
            yearimp = Convert.ToInt32(Console.ReadLine());
            ImportDate = new DateTime(yearimp, monthimp, dayimp);
            Console.Write("Write day of Expiration:");
            dayexp = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write month of Expiration:");
            monthexp = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write year of Expiration:");
            yearexp = Convert.ToInt32(Console.ReadLine());
            ExpirationDate = new DateTime(yearexp, monthexp, dayexp);

            var ingredient = new Ingredient(Name, Price, Amount, ImportDate, ExpirationDate);
            Ingredients.Add(ingredient);
        }

        private void UpdateIngredient()
        {
            string ingredname;
            decimal ingredPrice, ingredamount;
            int dayimp, monthimp, yearimp, dayexp, monthexp, yearexp;
            DateTime NewImportDate, NewExpirationDate;

            Console.Write("Enter the name of ingredient you want to change: ");
            ingredname = Console.ReadLine();
            Console.Write("Write new price:");
            ingredPrice = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Write new amount:");
            ingredamount = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Write day:");
            dayimp = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write month:");
            monthimp = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write year:");
            yearimp = Convert.ToInt32(Console.ReadLine());
            NewImportDate = new DateTime(yearimp, monthimp, dayimp);                   
            Console.Write("Write exp day:");
            dayexp = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write exp month:");
            monthexp = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write exp year:");
            yearexp = Convert.ToInt32(Console.ReadLine());
            NewExpirationDate = new DateTime(yearexp, monthexp, dayexp);              



            var ingredient = new Ingredient();
            var updateingredient = new Ingredient(ingredname, ingredPrice, ingredamount, NewImportDate, NewExpirationDate);

            bool result =  ingredient.UpdateObject(Ingredients, updateingredient);

            if(result)
            {
                Console.Write("Ingredient Updated");
            }
            else
            {
                Console.Write("Ingredient Not Found");
            }


        }

        private void DeleteIngredient()
        {
            Console.Write("Enter the name of the ingredient you want to delete:");
            string ingrname = Console.ReadLine();

            var ingredient = new Ingredient();
            ingredient.DeleteObject(Ingredients, ingrname);
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
            m.Add("2: CreateOrders", CreateOrders);
            m.Show();
            m.GetChoice();
            GoBack();
        }

        private void CreateOrders()
        {
            Orders.Add(1, 
                new List<Order>() {
                    new Order() {Id = 1, Address="Kharkiv", DishesOrder = Dishes }, 
                    new Order() {Id = 2, Address="Kharkiv", DishesOrder = Dishes },
                    new Order() {Id = 3, Address="Kharkiv", DishesOrder = Dishes }                 
                });
            Orders.Add(2, 
                new List<Order>() {
                    new Order() {Id = 5, Address="Kharkiv", DishesOrder = Dishes }, 
                    new Order() {Id = 6, Address="Kharkiv", DishesOrder = Dishes },
                    new Order() {Id = 7, Address="Kharkiv", DishesOrder = Dishes }                 
                });


                
        }

        private void PrintOrdersInfo()
        {
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
            string password, confirm, Name, Surname, Login, Email, PhoneNumber;
            int dayimp, monthimp, yearimp;
            DateOnly BirthDay;
            
            Console.Write("Enter User Name of the new User: ");
            Name = Console.ReadLine();
            Console.Write("Enter User Surname of the new User: ");
            Surname = Console.ReadLine();
            Console.Write("Enter User Login of the new User: ");
            Login = Console.ReadLine();
            Console.Write("Enter User Email of the new dish: ");
            Email = Console.ReadLine();
            Console.Write("Enter User Phone of the new dish: ");
            PhoneNumber = Console.ReadLine();
            Console.Write("Write your Birthday day:");
            dayimp = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write your Birthday month:");
            monthimp = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write your Birthday year:");
            yearimp = Convert.ToInt32(Console.ReadLine());
            BirthDay = new DateOnly(yearimp, monthimp, dayimp);    

            do
            {
                Console.Write("Write Password:");
                password = Console.ReadLine();
                Console.Write("Confirm Password:");
                confirm = Console.ReadLine();
            }
            while (password != confirm);    

            var user = new RestaurantUser (Name, Surname, Login, Email, PhoneNumber, BirthDay);
            RestaurantUsers.Add(user);
        }

        private void UpdateUser()
        {

            string userlogin, name, surname, password, confirm, email, phonenumber;
            int day, month, year;
            DateOnly NewBirthDay;

            Console.Write("Enter the Login of the User you want to change: ");
            userlogin = Console.ReadLine(); 
            Console.Write("Write new Name:");
            name = Console.ReadLine();
            Console.Write("Write new Surname:");
            surname = Console.ReadLine();
            Console.Write("Write new Email:");
            email = Console.ReadLine();
            Console.Write("Write new Phonenumber:");
            phonenumber = Console.ReadLine();


            Console.Write("Write day:");
            day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write month:");
            month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write year:");
            year = Convert.ToInt32(Console.ReadLine());
            NewBirthDay = new DateOnly(year, month, day);
            do
            {
                Console.Write("Write Password:");
                password = Console.ReadLine();
                Console.Write("Confirm Password:");
                confirm = Console.ReadLine();
            }
            while (password != confirm);         

            var user = new RestaurantUser();
            var updateuser = new RestaurantUser(name, surname, userlogin, email, phonenumber, NewBirthDay);

            bool result = user.UpdateObject(RestaurantUsers, updateuser);

            if(result)
            {
                Console.Write("User Updated");
            }
            else
            {
                Console.Write("User Not Found");
            }


        }




        private void DeleteUser()
        {
            Console.Write("Enter the Login of the User you want to delete:");
            string userlogin = Console.ReadLine();

            var user = new RestaurantUser();
            user.DeleteObject(RestaurantUsers, userlogin);
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

        private void PrintUsersInfo()
        {           
            _infoPrinterService.PrintAllUsersInfo(RestaurantUsers);
        }
    }
}
