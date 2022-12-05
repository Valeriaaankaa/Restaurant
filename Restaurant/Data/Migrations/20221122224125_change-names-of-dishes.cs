using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class changenamesofdishes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimeBegin",
                table: "TableOrders");

            migrationBuilder.DropColumn(
                name: "TimeEnd",
                table: "TableOrders");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "RestaurantTables",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "People",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "People",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "People",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Orders",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 25,
                column: "Name",
                value: "Vodka");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 26,
                column: "Name",
                value: "Gin");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 27,
                column: "Name",
                value: "Baijiu");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 28,
                column: "Name",
                value: "Soju");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 29,
                column: "Name",
                value: "Tequila");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 30,
                column: "Name",
                value: "Rum");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 31,
                column: "Name",
                value: "Beetroot with herby tzatziki");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 32,
                column: "Name",
                value: "Prawn cocktail");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 33,
                column: "Name",
                value: "Charred leek and goat's cheese tartlets");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 34,
                column: "Name",
                value: "Prawn tom yum soup");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 35,
                column: "Name",
                value: "Chilli and lime whitebait");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 36,
                column: "Name",
                value: "Pint of prawns");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 37,
                column: "Name",
                value: "Deep-Fried turley");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 38,
                column: "Name",
                value: "Easy rib eye roast");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 39,
                column: "Name",
                value: "Pesto pasta with chicken");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 40,
                column: "Name",
                value: "Oxtails with Gravy");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 41,
                column: "Name",
                value: "Stuffed green peppers");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 42,
                column: "Name",
                value: "Down Home Chitterlings");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 55,
                column: "Name",
                value: "Bacon wrapped turkey");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 56,
                column: "Name",
                value: "Stuffing meatloaf");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 57,
                column: "Name",
                value: "Baked lemon butter chicken thighs");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 58,
                column: "Name",
                value: "Easter ham");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 59,
                column: "Name",
                value: "pork L");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 67,
                column: "Name",
                value: "Coconut Kheer");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 68,
                column: "Name",
                value: "Low Fat Tiramisu");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 69,
                column: "Name",
                value: "Fudgy Chewy Brownies");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 71,
                column: "Name",
                value: "Pistachio Phirni");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 72,
                column: "Name",
                value: "Almond Malai Kulfi");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                column: "Amount",
                value: 100m);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IngredientGroup", "Name" },
                values: new object[] { 0, "Milk" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IngredientGroup", "Name" },
                values: new object[] { 0, "Yoghurt" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 7, 1, "Cream" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "IngredientMeasurement", "Name" },
                values: new object[] { 1, "Egg" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 4, 1, "Orange" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 4, 1, "Lemon" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 4, 1, "Mango" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 4, 1, "Blueberry" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "IngredientGroup", "Name" },
                values: new object[] { 4, "Raspberry" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 4, 1, "Strawberry" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IngredientMeasurement", "Name" },
                values: new object[] { 1, "Oil" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IngredientMeasurement", "Name" },
                values: new object[] { 1, "Chicken breast" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IngredientMeasurement", "Name" },
                values: new object[] { 1, "Beef" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IngredientMeasurement", "Name" },
                values: new object[] { 1, "Minced meat" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IngredientMeasurement", "Name" },
                values: new object[] { 1, "Salmon" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 0, 1, "Cacao" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IngredientMeasurement", "Name" },
                values: new object[] { 1, "Sugar" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IngredientMeasurement", "Name" },
                values: new object[] { 1, "Almonds" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 10, 1, "Cashew nuts" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "IngredientMeasurement", "Name" },
                values: new object[] { 1, "Kidney beans" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "IngredientMeasurement", "Name" },
                values: new object[] { 1, "White beans" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "IngredientMeasurement", "Name" },
                values: new object[] { 1, "Lentils" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 9, 1, "Pasta" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 9, 1, "Rice" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 10, 1, "Chili" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 9, 1, "Ginger" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 8, 1, "Mushroom" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 8, 1, "Potato" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 8, 1, "Peas" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 8, 1, "Root celery" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 8, 1, "Carrot" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 8, 1, "Zucchini" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 8, 1, "Tomato" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 8, 1, "Bell Pepper" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "IngredientMeasurement", "Name" },
                values: new object[] { 1, "Cucumber" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "IngredientMeasurement", "Name" },
                values: new object[] { 1, "Eggplant" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "IngredientMeasurement", "Name" },
                values: new object[] { 1, "Garlic" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "IngredientMeasurement", "Name" },
                values: new object[] { 1, "Onion" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "IngredientMeasurement", "Name" },
                values: new object[] { 1, "Leek" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "IngredientMeasurement", "Name" },
                values: new object[] { 1, "Cabbage" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "IngredientMeasurement", "Name" },
                values: new object[] { 1, "Kohlrabi" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "IngredientMeasurement", "Name" },
                values: new object[] { 1, "Celery" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "IngredientMeasurement", "Name" },
                values: new object[] { 1, "Spinach" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "IngredientMeasurement", "Name" },
                values: new object[] { 1, "Avocado" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "IngredientMeasurement", "Name" },
                values: new object[] { 1, "Flour" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "IngredientMeasurement", "Name" },
                values: new object[] { 1, "Dough" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "IngredientMeasurement", "Name" },
                values: new object[] { 1, "Rice paper" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "IngredientMeasurement", "Name" },
                values: new object[] { 1, "Plant milk" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "IngredientMeasurement", "Name" },
                values: new object[] { 1, "Joney" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 7, 1, "Chocolate" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 7, 1, "Bread" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 7, 1, "Candy" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 7, 1, "Cookie" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "IngredientGroup", "Name" },
                values: new object[] { 0, "Juice" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 2, 1, "Tuna fish" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 2, 1, "Shark" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 2, 1, "Sardines" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 2, 1, "Salmon" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 2, 1, "Prawn" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 2, 1, "Perch" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 2, 1, "Mussels" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 2, 1, "Squid" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 4, 1, "Kiwi" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 4, 1, "Cranberry" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 4, 1, "Tomato" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 4, 1, "Papaya" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 4, 1, "Olives" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 4, 1, "Pear" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 2, 1, "Sultana" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "IngredientGroup", "Name" },
                values: new object[] { 0, "Lemon Juice" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "IngredientGroup", "Name" },
                values: new object[] { 0, "Lemon rind" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "TimeBegin",
                table: "TableOrders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "TimeEnd",
                table: "TableOrders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "RestaurantTables",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "People",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "People",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "People",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 25,
                column: "Name",
                value: "NEGRONI");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 26,
                column: "Name",
                value: "MARTINI");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 27,
                column: "Name",
                value: "MANHATTAN");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 28,
                column: "Name",
                value: "WHISKEY SOUR");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 29,
                column: "Name",
                value: "OLD FASHIONED");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 30,
                column: "Name",
                value: "BLOODY MARY");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 31,
                column: "Name",
                value: "Roasted stuffed mushrooms");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 32,
                column: "Name",
                value: "Baked spring rolls");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 33,
                column: "Name",
                value: "Baked spring rolls");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 34,
                column: "Name",
                value: "Sweet fried saganaki");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 35,
                column: "Name",
                value: "Bacon rings");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 36,
                column: "Name",
                value: "Blooming onion");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 37,
                column: "Name",
                value: "CALZONES");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 38,
                column: "Name",
                value: "Deep Fried Main Dishes");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 39,
                column: "Name",
                value: "MEATBALLS");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 40,
                column: "Name",
                value: "QUICHE");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 41,
                column: "Name",
                value: "CHICKEN MAIN DISHES");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 42,
                column: "Name",
                value: "SEAFOOD MAIN DISHES");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 55,
                column: "Name",
                value: "Roasted stuffed mushrooms");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 56,
                column: "Name",
                value: "Baked spring rolls");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 57,
                column: "Name",
                value: "Baked spring rolls");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 58,
                column: "Name",
                value: "Sweet fried saganaki");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 59,
                column: "Name",
                value: "Bacon rings");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 67,
                column: "Name",
                value: "TIRAMISU LAYER CAKE");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 68,
                column: "Name",
                value: "DEVIL'S FOOD CAKE");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 69,
                column: "Name",
                value: "LEMON SOUFFLES");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 71,
                column: "Name",
                value: "LEMON CAKE DOBERGE");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 72,
                column: "Name",
                value: "CHOCOLATE FONDUE");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                column: "Amount",
                value: 23m);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IngredientGroup", "Name" },
                values: new object[] { 1, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IngredientGroup", "Name" },
                values: new object[] { 1, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 1, 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "IngredientMeasurement", "Name" },
                values: new object[] { 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 1, 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 1, 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 1, 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 1, 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "IngredientGroup", "Name" },
                values: new object[] { 1, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 1, 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IngredientMeasurement", "Name" },
                values: new object[] { 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IngredientMeasurement", "Name" },
                values: new object[] { 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IngredientMeasurement", "Name" },
                values: new object[] { 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IngredientMeasurement", "Name" },
                values: new object[] { 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IngredientMeasurement", "Name" },
                values: new object[] { 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 1, 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IngredientMeasurement", "Name" },
                values: new object[] { 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IngredientMeasurement", "Name" },
                values: new object[] { 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 1, 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "IngredientMeasurement", "Name" },
                values: new object[] { 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "IngredientMeasurement", "Name" },
                values: new object[] { 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "IngredientMeasurement", "Name" },
                values: new object[] { 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 1, 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 1, 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 1, 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 1, 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 1, 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 1, 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 1, 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 1, 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 1, 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 1, 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 1, 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 1, 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "IngredientMeasurement", "Name" },
                values: new object[] { 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "IngredientMeasurement", "Name" },
                values: new object[] { 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "IngredientMeasurement", "Name" },
                values: new object[] { 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "IngredientMeasurement", "Name" },
                values: new object[] { 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "IngredientMeasurement", "Name" },
                values: new object[] { 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "IngredientMeasurement", "Name" },
                values: new object[] { 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "IngredientMeasurement", "Name" },
                values: new object[] { 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "IngredientMeasurement", "Name" },
                values: new object[] { 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "IngredientMeasurement", "Name" },
                values: new object[] { 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "IngredientMeasurement", "Name" },
                values: new object[] { 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "IngredientMeasurement", "Name" },
                values: new object[] { 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "IngredientMeasurement", "Name" },
                values: new object[] { 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "IngredientMeasurement", "Name" },
                values: new object[] { 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "IngredientMeasurement", "Name" },
                values: new object[] { 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "IngredientMeasurement", "Name" },
                values: new object[] { 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 1, 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 1, 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 1, 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 1, 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "IngredientGroup", "Name" },
                values: new object[] { 1, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 1, 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 1, 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 1, 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 1, 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 1, 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 1, 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 1, 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 1, 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 1, 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 1, 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 1, 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 1, 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 1, 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 1, 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "IngredientGroup", "IngredientMeasurement", "Name" },
                values: new object[] { 1, 0, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "IngredientGroup", "Name" },
                values: new object[] { 1, "Pork" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "IngredientGroup", "Name" },
                values: new object[] { 1, "Pork" });
        }
    }
}
