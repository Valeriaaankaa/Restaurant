using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Data
{
    public class RestaurantDbContext : DbContext, IRestaurantDbContext
    {
        public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options) : base(options)
        {
        }

        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<DishComposition> DishCompositions { get; set; }
        public DbSet<DishOrder> DishOrders { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<RestaurantTable> RestaurantTables { get; set; }
        public DbSet<RestaurantUser> RestaurantUsers { get; set; }
        public DbSet<TableOrder> TableOrders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ingredient>().HasData(
               new Ingredient { Id = 1, DishId = 1, Name = "Water", Amount = 1, ExpirationDate = new DateTime(2011, 1, 30), ImportDate = new DateTime(2011, 1, 1), Price = 5 },
               new Ingredient { Id = 2, DishId = 2, Name = "Beer", Amount = 1, ExpirationDate = new DateTime(2011, 1, 30), ImportDate = new DateTime(2011, 1, 1), Price = 5 },
               new Ingredient { Id = 3, DishId = 3, Name = "Milk", Amount = 1, ExpirationDate = new DateTime(2011, 1, 30), ImportDate = new DateTime(2011, 1, 1), Price = 5 }
               );

            modelBuilder.Entity<Dish>().HasData(
                new Dish
                {
                    Id = 1,
                    Description = "The Botanist gin, Campari, Vermouth Di Torino",
                    DishGroup = DishGroup.Alcohol,
                    ImgPath = "/img/menu/NEGRONI.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "NEGRONI",
                    Price = 1
                    
                },

                new Dish
                {
                    Id = 2,
                    Description = "Tanqueray London Dry gin, Noilly Prat dry vermouth",
                    DishGroup = DishGroup.Alcohol,
                    ImgPath = "/img/menu/martini.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "MARTINI",
                    Price = 2
                },

                new Dish
                {
                    Id = 3,
                    Description = "Sazerac Rye whiskey, Cocchi Vermouth Di Torino",
                    DishGroup = DishGroup.Alcohol,
                    ImgPath = "/img/menu/manhattan.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "MANHATTAN",
                    Price = 3
                },

                new Dish
                {
                    Id = 4,
                    Description = "Four Roses Yellow Label bourbon, lemon",
                    DishGroup = DishGroup.Alcohol,
                    ImgPath = "/img/menu/whiskey_sour.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "WHISKEY SOUR",
                    Price = 4
                },

                new Dish
                {
                    Id = 5,
                    Description = "Buffalo Trace bourbon, demerara, Angostura Bitters",
                    DishGroup = DishGroup.Alcohol,
                    ImgPath = "/img/menu/OLD_FASHIONED.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "OLD FASHIONED",
                    Price = 5
                },

                new Dish
                {
                    Id = 6,
                    Description = "Grey Goose vodka, tomato juice, lemon, celery, olives, Fridays® seasoning. Served with the usual accompaniments.",
                    DishGroup = DishGroup.Alcohol,
                    ImgPath = "/img/menu/BLOODY_MARY.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "BLOODY MARY",
                    Price = 6
                },

                new Dish
                {
                    Id = 7,
                    Description = "The microwave is a great way to reheat stuffed mushrooms because it's gentle and it doesn't dry them out. Plus, it's a quick and easy way to heat them up without having to use the oven or the stovetop.",
                    DishGroup = DishGroup.Starters,
                    ImgPath = "/img/menu/Roasted_stuffed_mushrooms.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "Roasted stuffed mushrooms",
                    Price = 19.99m
                },

                new Dish
                {
                    Id = 8,
                    Description = "Roll each wrapper on the diagonal to enclose filling, folding in sides after first complete turn. Place spring rolls on prepared trays, seam-side down; brush",
                    DishGroup = DishGroup.Starters,
                    ImgPath = "/img/menu/Baked_spring_rolls.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "Baked spring rolls",
                    Price = 18.50m
                },

                new Dish
                {
                    Id = 9,
                    Description = "This contemporary take on beef Wellington reimagines pastry-wrapped tenderloin as a tart, showcasing flavors both comforting and complex.",
                    DishGroup = DishGroup.Starters,
                    ImgPath = "/img/menu/Baked_spring_rolls.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "Baked spring rolls",
                    Price = 7.05m
                },

                new Dish
                {
                    Id = 10,
                    Description = "Creamy pan-fried feta cheese with a golden crust is a delicious ... With the salty feta and sweet honey on top, this feta saganaki ",
                    DishGroup = DishGroup.Starters,
                    ImgPath = "/img/menu/Sweet_fried_saganaki.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "Sweet fried saganaki",
                    Price = 29.95m
                },

                new Dish
                {
                    Id = 11,
                    Description = "If you fancy making yourself a little treat, try these tasty bacon wrapped onion rings. We replaced the traditional breadcrumbs with streaky bacon",
                    DishGroup = DishGroup.Starters,
                    ImgPath = "/img/menu/Bacon_rings.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "Bacon rings",
                    Price = 38.51m
                },

                new Dish
                {
                    Id = 12,
                    Description = "A blooming onion, also called onion bloom, onion blossom, onion flower, bloomin' onion, or onion mum, is a dish consisting of one large onion",
                    DishGroup = DishGroup.Starters,
                    ImgPath = "/img/menu/Blooming_onion.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "Blooming onion",
                    Price = 10.30m
                },

                new Dish
                {
                    Id = 13,
                    Description = "Calzones are Italian turnovers that are stuffed with an array of ingredients. Pretty much anything that goes on a pizza can go into a calzone",
                    DishGroup = DishGroup.MainPlates,
                    ImgPath = "/img/menu/CALZONES.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "CALZONES",
                    Price = 27.95m
                },

                new Dish
                {
                    Id = 14,
                    Description = "Deep Fried Main Dishes. Fried chicken. Fish Tacos. Corn dogs. Finger Steaks. When you're in the mood for crispy fried food, these 5-star recipes do it right",
                    DishGroup = DishGroup.MainPlates,
                    ImgPath = "/img/menu/DEEP_FRIED_MAIN_DISHES.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "Deep Fried Main Dishes",
                    Price = 35.95m
                },

                new Dish
                {
                    Id = 15,
                    Description = "Ground beef or a mix of ground beef, pork and sometimes veal or venison, finely chopped (fried) onions, some broth, often with cream and sometimes with breadcrumbs soaked in milk",
                    DishGroup = DishGroup.MainPlates,
                    ImgPath = "/img/menu/MEATBALLS.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "MEATBALLS",
                    Price = 33.95m
                },

                new Dish
                {
                    Id = 16,
                    Description = "A pielike dish consisting of an unsweetened pastry shell filled with a custard and usually containing cheese and other ingredients, as vegetables, seafood",
                    DishGroup = DishGroup.MainPlates,
                    ImgPath = "/img/menu/QUICHE.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "QUICHE",
                    Price = 11.95m
                },

                new Dish
                {
                    Id = 17,
                    Description = "We've rounded up our 60 best chicken breast recipes, all of which are pretty easy, ... An easy, cheesy chicken breast supper that's as basic as they come",
                    DishGroup = DishGroup.MainPlates,
                    ImgPath = "/img/menu/CHICKEN_MAIN_DISHES.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "CHICKEN MAIN DISHES",
                    Price = 22.95m
                },

                new Dish
                {
                    Id = 18,
                    Description = "From seafood pastas and paellas, to creamy chowders and curries, our seafood recipes celebrate prawns, crab, clams, mussels and more.",
                    DishGroup = DishGroup.MainPlates,
                    ImgPath = "/img/menu/SEAFOOD_MAIN_DISHES.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "SEAFOOD MAIN DISHES",
                    Price = 11.95m
                },

                new Dish
                {
                    Id = 19,
                    Description = "Tiramisu cake is made of moist and fluffy vanilla layers soaked with a mixture of brandy, coffee liqueur and espresso",
                    DishGroup = DishGroup.Desert,
                    ImgPath = "/img/menu/TIRAMISU_LAYER_CAKE.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "TIRAMISU LAYER CAKE",
                    Price = 18.95m
                },

                new Dish
                {
                    Id = 20,
                    Description = "Devil's Food Cake is a variety of chocolate cake that uses cocoa powder instead of melted chocolate which is found in many chocolate cake recipes.",
                    DishGroup = DishGroup.Desert,
                    ImgPath = "/img/menu/DEVIL'S_FOOD_CAKE.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "DEVIL'S FOOD CAKE",
                    Price = 15.95m
                },

                new Dish
                {
                    Id = 21,
                    Description = "Lemon Soufflés are made with only three ingredients: lemons, sugar, and eggs. They are so simple but so delicous and make a big impact when served in lemon juice",
                    DishGroup = DishGroup.Desert,
                    ImgPath = "/img/menu/LEMON_SOUFFLES.jpg ",
                    Ingredients = new List<Ingredient>(),
                    Name = "LEMON SOUFFLES",
                    Price = 22.95m
                },

                new Dish
                {
                    Id = 22,
                    Description = "Baklava is a layered pastry dessert made of filo pastry, filled with chopped nuts, and sweetened with syrup or honey ",
                    DishGroup = DishGroup.Desert,
                    ImgPath = "/img/menu/BAKLAVA.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "BAKLAVA",
                    Price = 11.95m
                },

                new Dish
                {
                    Id = 23,
                    Description = "Our classic 8'' doberge cakes boast six layers of rich buttermilk cake sandwiching our handmade custard, frosted with our creamy buttercream, ",
                    DishGroup = DishGroup.Desert,
                    ImgPath = "/img/menu/LEMON_CAKE_DOBERGE.jpg ",
                    Ingredients = new List<Ingredient>(),
                    Name = "LEMON CAKE DOBERGE",
                    Price = 33.95m
                },

                new Dish
                {
                    Id = 24,
                    Description = "In a saucepan, combine the chocolate, milk and cream and heat on low, stirring often, until the chocolate is completely melted and the mixture ",
                    DishGroup = DishGroup.Desert,
                    ImgPath = "/img/menu/CHOCOLATE_FONDUE.jpg ",
                    Ingredients = new List<Ingredient>(),
                    Name = "CHOCOLATE FONDUE",
                    Price = 44.95m
                },
                new Dish
                {
                    Id = 25,
                    Description = "The Botanist gin, Campari, Vermouth Di Torino",
                    DishGroup = DishGroup.Alcohol,
                    ImgPath = "/img/menu/NEGRONI.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "NEGRONI",
                    Price = 25

                },

                new Dish
                {
                    Id = 26,
                    Description = "Tanqueray London Dry gin, Noilly Prat dry vermouth",
                    DishGroup = DishGroup.Alcohol,
                    ImgPath = "/img/menu/martini.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "MARTINI",
                    Price = 26
                },

                new Dish
                {
                    Id = 27,
                    Description = "Sazerac Rye whiskey, Cocchi Vermouth Di Torino",
                    DishGroup = DishGroup.Alcohol,
                    ImgPath = "/img/menu/manhattan.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "MANHATTAN",
                    Price = 27
                },

                new Dish
                {
                    Id = 28,
                    Description = "Four Roses Yellow Label bourbon, lemon",
                    DishGroup = DishGroup.Alcohol,
                    ImgPath = "/img/menu/whiskey_sour.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "WHISKEY SOUR",
                    Price = 28
                },

                new Dish
                {
                    Id = 29,
                    Description = "Buffalo Trace bourbon, demerara, Angostura Bitters",
                    DishGroup = DishGroup.Alcohol,
                    ImgPath = "/img/menu/OLD_FASHIONED.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "OLD FASHIONED",
                    Price = 29
                },

                new Dish
                {
                    Id = 30,
                    Description = "Grey Goose vodka, tomato juice, lemon, celery, olives, Fridays® seasoning. Served with the usual accompaniments.",
                    DishGroup = DishGroup.Alcohol,
                    ImgPath = "/img/menu/BLOODY_MARY.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "BLOODY MARY",
                    Price = 30
                },

                new Dish
                {
                    Id = 31,
                    Description = "The microwave is a great way to reheat stuffed mushrooms because it's gentle and it doesn't dry them out. Plus, it's a quick and easy way to heat them up without having to use the oven or the stovetop.",
                    DishGroup = DishGroup.Starters,
                    ImgPath = "/img/menu/Roasted_stuffed_mushrooms.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "Roasted stuffed mushrooms",
                    Price = 31
                },

                new Dish
                {
                    Id = 32,
                    Description = "Roll each wrapper on the diagonal to enclose filling, folding in sides after first complete turn. Place spring rolls on prepared trays, seam-side down; brush",
                    DishGroup = DishGroup.Starters,
                    ImgPath = "/img/menu/Baked_spring_rolls.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "Baked spring rolls",
                    Price = 32
                },

                new Dish
                {
                    Id = 33,
                    Description = "This contemporary take on beef Wellington reimagines pastry-wrapped tenderloin as a tart, showcasing flavors both comforting and complex.",
                    DishGroup = DishGroup.Starters,
                    ImgPath = "/img/menu/Baked_spring_rolls.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "Baked spring rolls",
                    Price = 33
                },

                new Dish
                {
                    Id = 34,
                    Description = "Creamy pan-fried feta cheese with a golden crust is a delicious ... With the salty feta and sweet honey on top, this feta saganaki ",
                    DishGroup = DishGroup.Starters,
                    ImgPath = "/img/menu/Sweet_fried_saganaki.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "Sweet fried saganaki",
                    Price = 34
                },

                new Dish
                {
                    Id = 35,
                    Description = "If you fancy making yourself a little treat, try these tasty bacon wrapped onion rings. We replaced the traditional breadcrumbs with streaky bacon",
                    DishGroup = DishGroup.Starters,
                    ImgPath = "/img/menu/Bacon_rings.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "Bacon rings",
                    Price = 35
                },

                new Dish
                {
                    Id = 36,
                    Description = "A blooming onion, also called onion bloom, onion blossom, onion flower, bloomin' onion, or onion mum, is a dish consisting of one large onion",
                    DishGroup = DishGroup.Starters,
                    ImgPath = "/img/menu/Blooming_onion.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "Blooming onion",
                    Price = 36
                },

                new Dish
                {
                    Id = 37,
                    Description = "Calzones are Italian turnovers that are stuffed with an array of ingredients. Pretty much anything that goes on a pizza can go into a calzone",
                    DishGroup = DishGroup.MainPlates,
                    ImgPath = "/img/menu/CALZONES.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "CALZONES",
                    Price = 37
                },

                new Dish
                {
                    Id = 38,
                    Description = "Deep Fried Main Dishes. Fried chicken. Fish Tacos. Corn dogs. Finger Steaks. When you're in the mood for crispy fried food, these 5-star recipes do it right",
                    DishGroup = DishGroup.MainPlates,
                    ImgPath = "/img/menu/DEEP_FRIED_MAIN_DISHES.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "Deep Fried Main Dishes",
                    Price = 38
                },

                new Dish
                {
                    Id = 39,
                    Description = "Ground beef or a mix of ground beef, pork and sometimes veal or venison, finely chopped (fried) onions, some broth, often with cream and sometimes with breadcrumbs soaked in milk",
                    DishGroup = DishGroup.MainPlates,
                    ImgPath = "/img/menu/MEATBALLS.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "MEATBALLS",
                    Price = 39
                },

                new Dish
                {
                    Id = 40,
                    Description = "A pielike dish consisting of an unsweetened pastry shell filled with a custard and usually containing cheese and other ingredients, as vegetables, seafood",
                    DishGroup = DishGroup.MainPlates,
                    ImgPath = "/img/menu/QUICHE.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "QUICHE",
                    Price = 40
                },

                new Dish
                {
                    Id = 41,
                    Description = "We've rounded up our 60 best chicken breast recipes, all of which are pretty easy, ... An easy, cheesy chicken breast supper that's as basic as they come",
                    DishGroup = DishGroup.MainPlates,
                    ImgPath = "/img/menu/CHICKEN_MAIN_DISHES.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "CHICKEN MAIN DISHES",
                    Price = 41
                },

                new Dish
                {
                    Id = 42,
                    Description = "From seafood pastas and paellas, to creamy chowders and curries, our seafood recipes celebrate prawns, crab, clams, mussels and more.",
                    DishGroup = DishGroup.MainPlates,
                    ImgPath = "/img/menu/SEAFOOD_MAIN_DISHES.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "SEAFOOD MAIN DISHES",
                    Price = 42
                },

                new Dish
                {
                    Id = 43,
                    Description = "Tiramisu cake is made of moist and fluffy vanilla layers soaked with a mixture of brandy, coffee liqueur and espresso",
                    DishGroup = DishGroup.Desert,
                    ImgPath = "/img/menu/TIRAMISU_LAYER_CAKE.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "TIRAMISU LAYER CAKE",
                    Price = 43
                },

                new Dish
                {
                    Id = 44,
                    Description = "Devil's Food Cake is a variety of chocolate cake that uses cocoa powder instead of melted chocolate which is found in many chocolate cake recipes.",
                    DishGroup = DishGroup.Desert,
                    ImgPath = "/img/menu/DEVIL'S_FOOD_CAKE.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "DEVIL'S FOOD CAKE",
                    Price = 44
                },

                new Dish
                {
                    Id = 45,
                    Description = "Lemon Soufflés are made with only three ingredients: lemons, sugar, and eggs. They are so simple but so delicous and make a big impact when served in lemon juice",
                    DishGroup = DishGroup.Desert,
                    ImgPath = "/img/menu/LEMON_SOUFFLES.jpg ",
                    Ingredients = new List<Ingredient>(),
                    Name = "LEMON SOUFFLES",
                    Price = 45
                },

                new Dish
                {
                    Id = 46,
                    Description = "Baklava is a layered pastry dessert made of filo pastry, filled with chopped nuts, and sweetened with syrup or honey ",
                    DishGroup = DishGroup.Desert,
                    ImgPath = "/img/menu/BAKLAVA.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "BAKLAVA",
                    Price = 46
                },

                new Dish
                {
                    Id = 47,
                    Description = "Our classic 8'' doberge cakes boast six layers of rich buttermilk cake sandwiching our handmade custard, frosted with our creamy buttercream, ",
                    DishGroup = DishGroup.Desert,
                    ImgPath = "/img/menu/LEMON_CAKE_DOBERGE.jpg ",
                    Ingredients = new List<Ingredient>(),
                    Name = "LEMON CAKE DOBERGE",
                    Price = 47
                },

                new Dish
                {
                    Id = 48,
                    Description = "In a saucepan, combine the chocolate, milk and cream and heat on low, stirring often, until the chocolate is completely melted and the mixture ",
                    DishGroup = DishGroup.Desert,
                    ImgPath = "/img/menu/CHOCOLATE_FONDUE.jpg ",
                    Ingredients = new List<Ingredient>(),
                    Name = "CHOCOLATE FONDUE",
                    Price = 48
                },
                new Dish
                {
                    Id = 49,
                    Description = "The Botanist gin, Campari, Vermouth Di Torino",
                    DishGroup = DishGroup.Alcohol,
                    ImgPath = "/img/menu/NEGRONI.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "NEGRONI",
                    Price = 49

                },

                new Dish
                {
                    Id = 50,
                    Description = "Tanqueray London Dry gin, Noilly Prat dry vermouth",
                    DishGroup = DishGroup.Alcohol,
                    ImgPath = "/img/menu/martini.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "MARTINI",
                    Price = 50
                },

                new Dish
                {
                    Id = 51,
                    Description = "Sazerac Rye whiskey, Cocchi Vermouth Di Torino",
                    DishGroup = DishGroup.Alcohol,
                    ImgPath = "/img/menu/manhattan.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "MANHATTAN",
                    Price = 51
                },

                new Dish
                {
                    Id = 52,
                    Description = "Four Roses Yellow Label bourbon, lemon",
                    DishGroup = DishGroup.Alcohol,
                    ImgPath = "/img/menu/whiskey_sour.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "WHISKEY SOUR",
                    Price = 52
                },

                new Dish
                {
                    Id = 53,
                    Description = "Buffalo Trace bourbon, demerara, Angostura Bitters",
                    DishGroup = DishGroup.Alcohol,
                    ImgPath = "/img/menu/OLD_FASHIONED.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "OLD FASHIONED",
                    Price = 53
                },

                new Dish
                {
                    Id = 54,
                    Description = "Grey Goose vodka, tomato juice, lemon, celery, olives, Fridays® seasoning. Served with the usual accompaniments.",
                    DishGroup = DishGroup.Alcohol,
                    ImgPath = "/img/menu/BLOODY_MARY.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "BLOODY MARY",
                    Price = 54
                },

                new Dish
                {
                    Id = 55,
                    Description = "The microwave is a great way to reheat stuffed mushrooms because it's gentle and it doesn't dry them out. Plus, it's a quick and easy way to heat them up without having to use the oven or the stovetop.",
                    DishGroup = DishGroup.Starters,
                    ImgPath = "/img/menu/Roasted_stuffed_mushrooms.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "Roasted stuffed mushrooms",
                    Price = 55
                },

                new Dish
                {
                    Id = 56,
                    Description = "Roll each wrapper on the diagonal to enclose filling, folding in sides after first complete turn. Place spring rolls on prepared trays, seam-side down; brush",
                    DishGroup = DishGroup.Starters,
                    ImgPath = "/img/menu/Baked_spring_rolls.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "Baked spring rolls",
                    Price = 56
                },

                new Dish
                {
                    Id = 57,
                    Description = "This contemporary take on beef Wellington reimagines pastry-wrapped tenderloin as a tart, showcasing flavors both comforting and complex.",
                    DishGroup = DishGroup.Starters,
                    ImgPath = "/img/menu/Baked_spring_rolls.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "Baked spring rolls",
                    Price = 57
                },

                new Dish
                {
                    Id = 58,
                    Description = "Creamy pan-fried feta cheese with a golden crust is a delicious ... With the salty feta and sweet honey on top, this feta saganaki ",
                    DishGroup = DishGroup.Starters,
                    ImgPath = "/img/menu/Sweet_fried_saganaki.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "Sweet fried saganaki",
                    Price = 58
                },

                new Dish
                {
                    Id = 59,
                    Description = "If you fancy making yourself a little treat, try these tasty bacon wrapped onion rings. We replaced the traditional breadcrumbs with streaky bacon",
                    DishGroup = DishGroup.Starters,
                    ImgPath = "/img/menu/Bacon_rings.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "Bacon rings",
                    Price = 59
                },

                new Dish
                {
                    Id = 60,
                    Description = "A blooming onion, also called onion bloom, onion blossom, onion flower, bloomin' onion, or onion mum, is a dish consisting of one large onion",
                    DishGroup = DishGroup.Starters,
                    ImgPath = "/img/menu/Blooming_onion.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "Blooming onion",
                    Price = 60
                },

                new Dish
                {
                    Id = 61,
                    Description = "Calzones are Italian turnovers that are stuffed with an array of ingredients. Pretty much anything that goes on a pizza can go into a calzone",
                    DishGroup = DishGroup.MainPlates,
                    ImgPath = "/img/menu/CALZONES.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "CALZONES",
                    Price = 61
                },

                new Dish
                {
                    Id = 62,
                    Description = "Deep Fried Main Dishes. Fried chicken. Fish Tacos. Corn dogs. Finger Steaks. When you're in the mood for crispy fried food, these 5-star recipes do it right",
                    DishGroup = DishGroup.MainPlates,
                    ImgPath = "/img/menu/DEEP_FRIED_MAIN_DISHES.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "Deep Fried Main Dishes",
                    Price = 62
                },

                new Dish
                {
                    Id = 63,
                    Description = "Ground beef or a mix of ground beef, pork and sometimes veal or venison, finely chopped (fried) onions, some broth, often with cream and sometimes with breadcrumbs soaked in milk",
                    DishGroup = DishGroup.MainPlates,
                    ImgPath = "/img/menu/MEATBALLS.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "MEATBALLS",
                    Price = 63
                },

                new Dish
                {
                    Id = 64,
                    Description = "A pielike dish consisting of an unsweetened pastry shell filled with a custard and usually containing cheese and other ingredients, as vegetables, seafood",
                    DishGroup = DishGroup.MainPlates,
                    ImgPath = "/img/menu/QUICHE.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "QUICHE",
                    Price = 64
                },

                new Dish
                {
                    Id = 65,
                    Description = "We've rounded up our 60 best chicken breast recipes, all of which are pretty easy, ... An easy, cheesy chicken breast supper that's as basic as they come",
                    DishGroup = DishGroup.MainPlates,
                    ImgPath = "/img/menu/CHICKEN_MAIN_DISHES.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "CHICKEN MAIN DISHES",
                    Price = 65
                },

                new Dish
                {
                    Id = 66,
                    Description = "From seafood pastas and paellas, to creamy chowders and curries, our seafood recipes celebrate prawns, crab, clams, mussels and more.",
                    DishGroup = DishGroup.MainPlates,
                    ImgPath = "/img/menu/SEAFOOD_MAIN_DISHES.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "SEAFOOD MAIN DISHES",
                    Price = 66
                },

                new Dish
                {
                    Id = 67,
                    Description = "Tiramisu cake is made of moist and fluffy vanilla layers soaked with a mixture of brandy, coffee liqueur and espresso",
                    DishGroup = DishGroup.Desert,
                    ImgPath = "/img/menu/TIRAMISU_LAYER_CAKE.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "TIRAMISU LAYER CAKE",
                    Price = 67
                },

                new Dish
                {
                    Id = 68,
                    Description = "Devil's Food Cake is a variety of chocolate cake that uses cocoa powder instead of melted chocolate which is found in many chocolate cake recipes.",
                    DishGroup = DishGroup.Desert,
                    ImgPath = "/img/menu/DEVIL'S_FOOD_CAKE.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "DEVIL'S FOOD CAKE",
                    Price = 68
                },

                new Dish
                {
                    Id = 69,
                    Description = "Lemon Soufflés are made with only three ingredients: lemons, sugar, and eggs. They are so simple but so delicous and make a big impact when served in lemon juice",
                    DishGroup = DishGroup.Desert,
                    ImgPath = "/img/menu/LEMON_SOUFFLES.jpg ",
                    Ingredients = new List<Ingredient>(),
                    Name = "LEMON SOUFFLES",
                    Price = 69
                },

                new Dish
                {
                    Id = 70,
                    Description = "Baklava is a layered pastry dessert made of filo pastry, filled with chopped nuts, and sweetened with syrup or honey ",
                    DishGroup = DishGroup.Desert,
                    ImgPath = "/img/menu/BAKLAVA.jpg",
                    Ingredients = new List<Ingredient>(),
                    Name = "BAKLAVA",
                    Price = 70
                },

                new Dish
                {
                    Id = 71,
                    Description = "Our classic 8'' doberge cakes boast six layers of rich buttermilk cake sandwiching our handmade custard, frosted with our creamy buttercream, ",
                    DishGroup = DishGroup.Desert,
                    ImgPath = "/img/menu/LEMON_CAKE_DOBERGE.jpg ",
                    Ingredients = new List<Ingredient>(),
                    Name = "LEMON CAKE DOBERGE",
                    Price = 71
                },

                new Dish
                {
                    Id = 72,
                    Description = "In a saucepan, combine the chocolate, milk and cream and heat on low, stirring often, until the chocolate is completely melted and the mixture ",
                    DishGroup = DishGroup.Desert,
                    ImgPath = "/img/menu/CHOCOLATE_FONDUE.jpg ",
                    Ingredients = new List<Ingredient>(),
                    Name = "CHOCOLATE FONDUE",
                    Price = 72
                }
























               );


            var dishIngredients = modelBuilder.Entity<Dish>();
            dishIngredients.HasMany(c => c.Ingredients)
                    .WithOne(r => r.Dish);


            base.OnModelCreating(modelBuilder);
        }
    }

}
