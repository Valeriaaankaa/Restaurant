﻿using Restaurant;

List<Dish> dishes = new List<Dish>();
List<User> users = new List<User>();
List<Order> orders = new List<Order>();
List<Ingredient> borschIngredients = new List<Ingredient>();



Seed_Data();
PrintDishesInfo();
PrintUsersInfo();
Console.ReadKey();



void Seed_Data()
{

    User user_one = new() { UserId = 1, UserName = "Pavel", UserSurname = "Rozenko", BirthDay = new DateTime(1990, 4, 3), Role = Role.User, PhoneNumber = "+38(066)322-22-11", UserEmail = "123@gmail.com", UserLogin = "login1", UserPassword = "*********" };
    User user_two = new() { UserId = 2, UserName = "Dmitro", UserSurname = "Potapenko", BirthDay = new DateTime(1995, 5, 2), Role = Role.User, PhoneNumber = "+38(066)322-22-12", UserEmail = "124@gmail.com", UserLogin = "login2", UserPassword = "*********" };
    User user_three = new() { UserId = 3, UserName = "Mihail", UserSurname = "Monenko", BirthDay = new DateTime(1998, 6, 29), Role = Role.User, PhoneNumber = "+38(066)322-22-13", UserEmail = "125@gmail.com", UserLogin = "login3", UserPassword = "*********" };
    User user_four = new() { UserId = 4, UserName = "Olena", UserSurname = "Pavlenko", BirthDay = new DateTime(1980, 1, 21), Role = Role.User, PhoneNumber = "+38(066)322-22-14", UserEmail = "126@gmail.com", UserLogin = "login4", UserPassword = "*********" };
    User user_five = new() { UserId = 5, UserName = "Irina", UserSurname = "Gorohowataja", BirthDay = new DateTime(1993, 3, 12), Role = Role.User, PhoneNumber = "+38(066)322-22-15", UserEmail = "127@gmail.com", UserLogin = "login5", UserPassword = "*********" };
    users.Add(user_one);
    users.Add(user_two);
    users.Add(user_three);
    users.Add(user_four);
    users.Add(user_five);

    Ingredient onion = new() { IngredientId = 1, IngredientName = "Onion", IngredientPrice = 10, IngredientAmount = 10, ImportDate = new DateTime(2022, 9, 4), ExpirationDate = new DateTime(2022, 9, 9) };
    Ingredient carrot = new() { IngredientId = 2, IngredientName = "Carrot", IngredientPrice = 40, IngredientAmount = 50, ImportDate = new DateTime(2022, 9, 4), ExpirationDate = new DateTime(2022, 9, 7) };
    Ingredient potato = new() { IngredientId = 3, IngredientName = "Potato", IngredientPrice = 40, IngredientAmount = 50, ImportDate = new DateTime(2022, 9, 4), ExpirationDate = new DateTime(2022, 9, 8) };
    Ingredient cabbage = new() { IngredientId = 4, IngredientName = "Cabbage", IngredientPrice = 20, IngredientAmount = 40, ImportDate = new DateTime(2022, 9, 4), ExpirationDate = new DateTime(2022, 9, 8) };
    Ingredient beet = new() { IngredientId = 5, IngredientName = "Beet", IngredientPrice = 90, IngredientAmount = 30, ImportDate = new DateTime(2022, 9, 4), ExpirationDate = new DateTime(2022, 9, 6) };
    Ingredient water = new() { IngredientId = 6, IngredientName = "Water", IngredientPrice = 3, IngredientAmount = 120, ImportDate = new DateTime(2022, 9, 4), ExpirationDate = new DateTime(2022, 9, 26) };
    borschIngredients.Add(onion);
    borschIngredients.Add(carrot);
    borschIngredients.Add(potato);
    borschIngredients.Add(cabbage);
    borschIngredients.Add(beet);
    borschIngredients.Add(water);


    Dish Olivie = new() { DishId = 1, DishName = "Olivie", DishGroup = DishGroup.Salat, DishPrice = 50, DishDescription = "Olivier salad is a traditional salad dish in Russian cuisine, which is also popular in other post-Soviet countries and around the world." };
    Dish Borshch = new() { DishId = 2, DishName = "Borshch", DishGroup = DishGroup.FirstDish, DishPrice = 70, DishDescription = "Ukrainian borscht is a hearty soup of beef and a variety of vegetables in which root vegetables and cabbage predominate, and the soup takes its characteristic deep red colour from beets" };
    Dish Beer = new() { DishId = 3, DishName = "Beer", DishGroup = DishGroup.Alcohol, DishPrice = 20, DishDescription = "Beer is an alcoholic beverage produced by extracting raw materials with water, boiling (usually with hops), and fermenting." };
    Dish Peperoni = new() { DishId = 4, DishName = "Peperoni", DishGroup = DishGroup.Pizza, DishPrice = 120, DishDescription = "Pepperoni is an American variety of spicy salami made from cured pork and beef seasoned with paprika or other chili pepper." };
    Dish Browni = new() { DishId = 5, DishName = "Browni", DishGroup = DishGroup.Desert, DishPrice = 30, DishDescription = "A chocolate brownie or simply a brownie is a square or rectangular chocolate baked confection. " };
   
    dishes.Add(Borshch);   
    
    Order order_one = new() { OrderId = 1, User = user_one, Address = "Kiev, Maidan Nezalegnosti, 222", OrderDate = new DateTime(2022, 6, 21, 22, 00, 00), OrderStatus = OrderStatus.InProgress };
    Order order_two = new() { OrderId = 2, User = user_four, Address = "Kharkiv, Maidan Konstitucii, 11", OrderDate = new DateTime(2022, 9, 4, 12, 00, 00), OrderStatus = OrderStatus.Done };
    orders.Add(order_one);
    orders.Add(order_two); 

}

void PrintUsersInfo()
{
    Console.WriteLine(new string('*', 17) + "Users in System" + new string('*', 17));
    foreach (var u in users)
    {
        Console.WriteLine(u);
    }
    Console.WriteLine(new string('*', 42));
}
void PrintDishesInfo()
{
    Console.WriteLine(new string('*', 17) + "Dishes in restaurant" + new string('*', 17));
    foreach (var d in dishes)
    {
        Console.WriteLine(d);
    }
    Console.WriteLine(new string('*', 42));

}


