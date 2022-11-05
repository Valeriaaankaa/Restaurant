using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class moreseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "Id", "Description", "DishGroup", "ImgPath", "Name", "Price" },
                values: new object[,]
                {
                    { 25, "The Botanist gin, Campari, Vermouth Di Torino", 6, "/img/menu/NEGRONI.jpg", "NEGRONI", 25m },
                    { 26, "Tanqueray London Dry gin, Noilly Prat dry vermouth", 6, "/img/menu/martini.jpg", "MARTINI", 26m },
                    { 27, "Sazerac Rye whiskey, Cocchi Vermouth Di Torino", 6, "/img/menu/manhattan.jpg", "MANHATTAN", 27m },
                    { 28, "Four Roses Yellow Label bourbon, lemon", 6, "/img/menu/whiskey_sour.jpg", "WHISKEY SOUR", 28m },
                    { 29, "Buffalo Trace bourbon, demerara, Angostura Bitters", 6, "/img/menu/OLD_FASHIONED.jpg", "OLD FASHIONED", 29m },
                    { 30, "Grey Goose vodka, tomato juice, lemon, celery, olives, Fridays® seasoning. Served with the usual accompaniments.", 6, "/img/menu/BLOODY_MARY.jpg", "BLOODY MARY", 30m },
                    { 31, "The microwave is a great way to reheat stuffed mushrooms because it's gentle and it doesn't dry them out. Plus, it's a quick and easy way to heat them up without having to use the oven or the stovetop.", 8, "/img/menu/Roasted_stuffed_mushrooms.jpg", "Roasted stuffed mushrooms", 31m },
                    { 32, "Roll each wrapper on the diagonal to enclose filling, folding in sides after first complete turn. Place spring rolls on prepared trays, seam-side down; brush", 8, "/img/menu/Baked_spring_rolls.jpg", "Baked spring rolls", 32m },
                    { 33, "This contemporary take on beef Wellington reimagines pastry-wrapped tenderloin as a tart, showcasing flavors both comforting and complex.", 8, "/img/menu/Baked_spring_rolls.jpg", "Baked spring rolls", 33m },
                    { 34, "Creamy pan-fried feta cheese with a golden crust is a delicious ... With the salty feta and sweet honey on top, this feta saganaki ", 8, "/img/menu/Sweet_fried_saganaki.jpg", "Sweet fried saganaki", 34m },
                    { 35, "If you fancy making yourself a little treat, try these tasty bacon wrapped onion rings. We replaced the traditional breadcrumbs with streaky bacon", 8, "/img/menu/Bacon_rings.jpg", "Bacon rings", 35m },
                    { 36, "A blooming onion, also called onion bloom, onion blossom, onion flower, bloomin' onion, or onion mum, is a dish consisting of one large onion", 8, "/img/menu/Blooming_onion.jpg", "Blooming onion", 36m },
                    { 37, "Calzones are Italian turnovers that are stuffed with an array of ingredients. Pretty much anything that goes on a pizza can go into a calzone", 9, "/img/menu/CALZONES.jpg", "CALZONES", 37m },
                    { 38, "Deep Fried Main Dishes. Fried chicken. Fish Tacos. Corn dogs. Finger Steaks. When you're in the mood for crispy fried food, these 5-star recipes do it right", 9, "/img/menu/DEEP_FRIED_MAIN_DISHES.jpg", "Deep Fried Main Dishes", 38m },
                    { 39, "Ground beef or a mix of ground beef, pork and sometimes veal or venison, finely chopped (fried) onions, some broth, often with cream and sometimes with breadcrumbs soaked in milk", 9, "/img/menu/MEATBALLS.jpg", "MEATBALLS", 39m },
                    { 40, "A pielike dish consisting of an unsweetened pastry shell filled with a custard and usually containing cheese and other ingredients, as vegetables, seafood", 9, "/img/menu/QUICHE.jpg", "QUICHE", 40m },
                    { 41, "We've rounded up our 60 best chicken breast recipes, all of which are pretty easy, ... An easy, cheesy chicken breast supper that's as basic as they come", 9, "/img/menu/CHICKEN_MAIN_DISHES.jpg", "CHICKEN MAIN DISHES", 41m },
                    { 42, "From seafood pastas and paellas, to creamy chowders and curries, our seafood recipes celebrate prawns, crab, clams, mussels and more.", 9, "/img/menu/SEAFOOD_MAIN_DISHES.jpg", "SEAFOOD MAIN DISHES", 42m },
                    { 43, "Tiramisu cake is made of moist and fluffy vanilla layers soaked with a mixture of brandy, coffee liqueur and espresso", 2, "/img/menu/TIRAMISU_LAYER_CAKE.jpg", "TIRAMISU LAYER CAKE", 43m },
                    { 44, "Devil's Food Cake is a variety of chocolate cake that uses cocoa powder instead of melted chocolate which is found in many chocolate cake recipes.", 2, "/img/menu/DEVIL'S_FOOD_CAKE.jpg", "DEVIL'S FOOD CAKE", 44m },
                    { 45, "Lemon Soufflés are made with only three ingredients: lemons, sugar, and eggs. They are so simple but so delicous and make a big impact when served in lemon juice", 2, "/img/menu/LEMON_SOUFFLES.jpg ", "LEMON SOUFFLES", 45m },
                    { 46, "Baklava is a layered pastry dessert made of filo pastry, filled with chopped nuts, and sweetened with syrup or honey ", 2, "/img/menu/BAKLAVA.jpg", "BAKLAVA", 46m },
                    { 47, "Our classic 8'' doberge cakes boast six layers of rich buttermilk cake sandwiching our handmade custard, frosted with our creamy buttercream, ", 2, "/img/menu/LEMON_CAKE_DOBERGE.jpg ", "LEMON CAKE DOBERGE", 47m },
                    { 48, "In a saucepan, combine the chocolate, milk and cream and heat on low, stirring often, until the chocolate is completely melted and the mixture ", 2, "/img/menu/CHOCOLATE_FONDUE.jpg ", "CHOCOLATE FONDUE", 48m },
                    { 49, "The Botanist gin, Campari, Vermouth Di Torino", 6, "/img/menu/NEGRONI.jpg", "NEGRONI", 49m },
                    { 50, "Tanqueray London Dry gin, Noilly Prat dry vermouth", 6, "/img/menu/martini.jpg", "MARTINI", 50m },
                    { 51, "Sazerac Rye whiskey, Cocchi Vermouth Di Torino", 6, "/img/menu/manhattan.jpg", "MANHATTAN", 51m },
                    { 52, "Four Roses Yellow Label bourbon, lemon", 6, "/img/menu/whiskey_sour.jpg", "WHISKEY SOUR", 52m },
                    { 53, "Buffalo Trace bourbon, demerara, Angostura Bitters", 6, "/img/menu/OLD_FASHIONED.jpg", "OLD FASHIONED", 53m },
                    { 54, "Grey Goose vodka, tomato juice, lemon, celery, olives, Fridays® seasoning. Served with the usual accompaniments.", 6, "/img/menu/BLOODY_MARY.jpg", "BLOODY MARY", 54m },
                    { 55, "The microwave is a great way to reheat stuffed mushrooms because it's gentle and it doesn't dry them out. Plus, it's a quick and easy way to heat them up without having to use the oven or the stovetop.", 8, "/img/menu/Roasted_stuffed_mushrooms.jpg", "Roasted stuffed mushrooms", 55m },
                    { 56, "Roll each wrapper on the diagonal to enclose filling, folding in sides after first complete turn. Place spring rolls on prepared trays, seam-side down; brush", 8, "/img/menu/Baked_spring_rolls.jpg", "Baked spring rolls", 56m },
                    { 57, "This contemporary take on beef Wellington reimagines pastry-wrapped tenderloin as a tart, showcasing flavors both comforting and complex.", 8, "/img/menu/Baked_spring_rolls.jpg", "Baked spring rolls", 57m },
                    { 58, "Creamy pan-fried feta cheese with a golden crust is a delicious ... With the salty feta and sweet honey on top, this feta saganaki ", 8, "/img/menu/Sweet_fried_saganaki.jpg", "Sweet fried saganaki", 58m },
                    { 59, "If you fancy making yourself a little treat, try these tasty bacon wrapped onion rings. We replaced the traditional breadcrumbs with streaky bacon", 8, "/img/menu/Bacon_rings.jpg", "Bacon rings", 59m },
                    { 60, "A blooming onion, also called onion bloom, onion blossom, onion flower, bloomin' onion, or onion mum, is a dish consisting of one large onion", 8, "/img/menu/Blooming_onion.jpg", "Blooming onion", 60m },
                    { 61, "Calzones are Italian turnovers that are stuffed with an array of ingredients. Pretty much anything that goes on a pizza can go into a calzone", 9, "/img/menu/CALZONES.jpg", "CALZONES", 61m },
                    { 62, "Deep Fried Main Dishes. Fried chicken. Fish Tacos. Corn dogs. Finger Steaks. When you're in the mood for crispy fried food, these 5-star recipes do it right", 9, "/img/menu/DEEP_FRIED_MAIN_DISHES.jpg", "Deep Fried Main Dishes", 62m },
                    { 63, "Ground beef or a mix of ground beef, pork and sometimes veal or venison, finely chopped (fried) onions, some broth, often with cream and sometimes with breadcrumbs soaked in milk", 9, "/img/menu/MEATBALLS.jpg", "MEATBALLS", 63m },
                    { 64, "A pielike dish consisting of an unsweetened pastry shell filled with a custard and usually containing cheese and other ingredients, as vegetables, seafood", 9, "/img/menu/QUICHE.jpg", "QUICHE", 64m },
                    { 65, "We've rounded up our 60 best chicken breast recipes, all of which are pretty easy, ... An easy, cheesy chicken breast supper that's as basic as they come", 9, "/img/menu/CHICKEN_MAIN_DISHES.jpg", "CHICKEN MAIN DISHES", 65m },
                    { 66, "From seafood pastas and paellas, to creamy chowders and curries, our seafood recipes celebrate prawns, crab, clams, mussels and more.", 9, "/img/menu/SEAFOOD_MAIN_DISHES.jpg", "SEAFOOD MAIN DISHES", 66m }
                });

            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "Id", "Description", "DishGroup", "ImgPath", "Name", "Price" },
                values: new object[,]
                {
                    { 67, "Tiramisu cake is made of moist and fluffy vanilla layers soaked with a mixture of brandy, coffee liqueur and espresso", 2, "/img/menu/TIRAMISU_LAYER_CAKE.jpg", "TIRAMISU LAYER CAKE", 67m },
                    { 68, "Devil's Food Cake is a variety of chocolate cake that uses cocoa powder instead of melted chocolate which is found in many chocolate cake recipes.", 2, "/img/menu/DEVIL'S_FOOD_CAKE.jpg", "DEVIL'S FOOD CAKE", 68m },
                    { 69, "Lemon Soufflés are made with only three ingredients: lemons, sugar, and eggs. They are so simple but so delicous and make a big impact when served in lemon juice", 2, "/img/menu/LEMON_SOUFFLES.jpg ", "LEMON SOUFFLES", 69m },
                    { 70, "Baklava is a layered pastry dessert made of filo pastry, filled with chopped nuts, and sweetened with syrup or honey ", 2, "/img/menu/BAKLAVA.jpg", "BAKLAVA", 70m },
                    { 71, "Our classic 8'' doberge cakes boast six layers of rich buttermilk cake sandwiching our handmade custard, frosted with our creamy buttercream, ", 2, "/img/menu/LEMON_CAKE_DOBERGE.jpg ", "LEMON CAKE DOBERGE", 71m },
                    { 72, "In a saucepan, combine the chocolate, milk and cream and heat on low, stirring often, until the chocolate is completely melted and the mixture ", 2, "/img/menu/CHOCOLATE_FONDUE.jpg ", "CHOCOLATE FONDUE", 72m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 72);
        }
    }
}
