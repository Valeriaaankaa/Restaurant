using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class seeddishes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImgPath",
                value: "/img/menu/manhattan.jpg");

            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "Id", "Description", "DishGroup", "ImgPath", "Name", "Price" },
                values: new object[,]
                {
                    { 4, "Four Roses Yellow Label bourbon, lemon", 6, "/img/menu/whiskey_sour.jpg", "WHISKEY SOUR", 4m },
                    { 5, "Buffalo Trace bourbon, demerara, Angostura Bitters", 6, "/img/menu/OLD_FASHIONED.jpg", "OLD FASHIONED", 5m },
                    { 6, "Grey Goose vodka, tomato juice, lemon, celery, olives, Fridays® seasoning. Served with the usual accompaniments.", 6, "/img/menu/BLOODY_MARY.jpg", "BLOODY MARY", 6m },
                    { 7, "The microwave is a great way to reheat stuffed mushrooms because it's gentle and it doesn't dry them out. Plus, it's a quick and easy way to heat them up without having to use the oven or the stovetop.", 8, "/img/menu/Roasted_stuffed_mushrooms.jpg", "Roasted stuffed mushrooms", 19.99m },
                    { 8, "Roll each wrapper on the diagonal to enclose filling, folding in sides after first complete turn. Place spring rolls on prepared trays, seam-side down; brush", 8, "/img/menu/Baked_spring_rolls.jpg", "Baked spring rolls", 18.50m },
                    { 9, "This contemporary take on beef Wellington reimagines pastry-wrapped tenderloin as a tart, showcasing flavors both comforting and complex.", 8, "/img/menu/Baked_spring_rolls.jpg", "Baked spring rolls", 7.05m },
                    { 10, "Creamy pan-fried feta cheese with a golden crust is a delicious ... With the salty feta and sweet honey on top, this feta saganaki ", 8, "/img/menu/Sweet_fried_saganaki.jpg", "Sweet fried saganaki", 29.95m },
                    { 11, "If you fancy making yourself a little treat, try these tasty bacon wrapped onion rings. We replaced the traditional breadcrumbs with streaky bacon", 8, "/img/menu/Bacon_rings.jpg", "Bacon rings", 38.51m },
                    { 12, "A blooming onion, also called onion bloom, onion blossom, onion flower, bloomin' onion, or onion mum, is a dish consisting of one large onion", 8, "/img/menu/Blooming_onion.jpg", "Blooming onion", 10.30m },
                    { 13, "Calzones are Italian turnovers that are stuffed with an array of ingredients. Pretty much anything that goes on a pizza can go into a calzone", 8, "/img/menu/CALZONES.jpg", "CALZONES", 27.95m },
                    { 14, "Deep Fried Main Dishes. Fried chicken. Fish Tacos. Corn dogs. Finger Steaks. When you're in the mood for crispy fried food, these 5-star recipes do it right", 8, "/img/menu/DEEP_FRIED_MAIN_DISHES.jpg", "Deep Fried Main Dishes", 35.95m },
                    { 15, "Ground beef or a mix of ground beef, pork and sometimes veal or venison, finely chopped (fried) onions, some broth, often with cream and sometimes with breadcrumbs soaked in milk", 8, "/img/menu/MEATBALLS.jpg", "MEATBALLS", 33.95m },
                    { 16, "A pielike dish consisting of an unsweetened pastry shell filled with a custard and usually containing cheese and other ingredients, as vegetables, seafood", 8, "/img/menu/QUICHE.jpg", "QUICHE", 11.95m },
                    { 17, "We've rounded up our 60 best chicken breast recipes, all of which are pretty easy, ... An easy, cheesy chicken breast supper that's as basic as they come", 8, "/img/menu/CHICKEN_MAIN_DISHES.jpg", "CHICKEN MAIN DISHES", 22.95m },
                    { 18, "From seafood pastas and paellas, to creamy chowders and curries, our seafood recipes celebrate prawns, crab, clams, mussels and more.", 8, "/img/menu/SEAFOOD_MAIN_DISHES.jpg", "SEAFOOD MAIN DISHES", 11.95m },
                    { 19, "Tiramisu cake is made of moist and fluffy vanilla layers soaked with a mixture of brandy, coffee liqueur and espresso", 2, "/img/menu/TIRAMISU_LAYER_CAKE.jpg", "TIRAMISU LAYER CAKE", 18.95m },
                    { 20, "Devil's Food Cake is a variety of chocolate cake that uses cocoa powder instead of melted chocolate which is found in many chocolate cake recipes.", 2, "/img/menu/DEVIL'S_FOOD_CAKE.jpg", "DEVIL'S FOOD CAKE", 15.95m },
                    { 21, "Lemon Soufflés are made with only three ingredients: lemons, sugar, and eggs. They are so simple but so delicous and make a big impact when served in lemon juice", 2, "/img/menu/LEMON_SOUFFLES.jpg ", "LEMON SOUFFLES", 22.95m },
                    { 22, "Baklava is a layered pastry dessert made of filo pastry, filled with chopped nuts, and sweetened with syrup or honey ", 2, "/img/menu/BAKLAVA.jpg", "BAKLAVA", 11.95m },
                    { 23, "Our classic 8'' doberge cakes boast six layers of rich buttermilk cake sandwiching our handmade custard, frosted with our creamy buttercream, ", 2, "/img/menu/LEMON_CAKE_DOBERGE.jpg ", "LEMON CAKE DOBERGE", 33.95m },
                    { 24, "In a saucepan, combine the chocolate, milk and cream and heat on low, stirring often, until the chocolate is completely melted and the mixture ", 2, "/img/menu/CHOCOLATE_FONDUE.jpg ", "CHOCOLATE FONDUE", 44.95m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImgPath",
                value: "/img/menu/martini.jpg");
        }
    }
}
