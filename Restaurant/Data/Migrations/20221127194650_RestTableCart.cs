using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class RestTableCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDay",
                table: "People");

            migrationBuilder.CreateTable(
                name: "RestCartTables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    restaurantId = table.Column<int>(type: "int", nullable: false),
                    RestCartId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestCartTables", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RestCartTables_RestaurantTables_restaurantId",
                        column: x => x.restaurantId,
                        principalTable: "RestaurantTables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Amount",
                value: 2m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 5,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 6,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 7,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 8,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 9,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 10,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 11,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 12,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 13,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 14,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 15,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 16,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 17,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 18,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 19,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 20,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 21,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 22,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 23,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 24,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 25,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 26,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 27,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 28,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 29,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 30,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 31,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 32,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 33,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 34,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 35,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 36,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 37,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 38,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 39,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 40,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 41,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 42,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 43,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 44,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 45,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 46,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 47,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 48,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 49,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 50,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 51,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 52,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 53,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 54,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 55,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 56,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 57,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 58,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 59,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 60,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 61,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 62,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 63,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 64,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 65,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 66,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 67,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 68,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 69,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 70,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 71,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 72,
                column: "Amount",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 10,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 11,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 12,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 13,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 14,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 15,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 16,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 17,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 18,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 19,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 20,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 21,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 22,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 23,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 24,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 25,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 26,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 27,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 28,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 29,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 30,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 31,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 32,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 33,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 34,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 35,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 36,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 37,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 38,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 39,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 40,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 41,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 42,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 43,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 44,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 45,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 46,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 47,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 48,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 49,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 50,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 51,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 52,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 53,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 54,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 55,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 56,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 57,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 58,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 59,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 60,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 61,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 62,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 63,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 64,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 65,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 66,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 67,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 68,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 69,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 70,
                column: "IngredientMeasurement",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 71,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 72,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_RestCartTables_restaurantId",
                table: "RestCartTables",
                column: "restaurantId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RestCartTables");

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDay",
                table: "People",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 5,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 6,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 7,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 8,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 9,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 10,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 11,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 12,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 13,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 14,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 15,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 16,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 17,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 18,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 19,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 20,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 21,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 22,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 23,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 24,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 25,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 26,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 27,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 28,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 29,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 30,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 31,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 32,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 33,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 34,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 35,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 36,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 37,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 38,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 39,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 40,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 41,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 42,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 43,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 44,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 45,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 46,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 47,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 48,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 49,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 50,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 51,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 52,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 53,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 54,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 55,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 56,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 57,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 58,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 59,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 60,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 61,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 62,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 63,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 64,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 65,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 66,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 67,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 68,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 69,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 70,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 71,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "DishCompositions",
                keyColumn: "Id",
                keyValue: 72,
                column: "Amount",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                column: "IngredientMeasurement",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                column: "IngredientMeasurement",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                column: "IngredientMeasurement",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 10,
                column: "IngredientMeasurement",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 11,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 12,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 13,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 14,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 15,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 16,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 17,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 18,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 19,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 20,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 21,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 22,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 23,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 24,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 25,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 26,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 27,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 28,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 29,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 30,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 31,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 32,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 33,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 34,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 35,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 36,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 37,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 38,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 39,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 40,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 41,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 42,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 43,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 44,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 45,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 46,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 47,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 48,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 49,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 50,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 51,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 52,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 53,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 54,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 55,
                column: "IngredientMeasurement",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 56,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 57,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 58,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 59,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 60,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 61,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 62,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 63,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 64,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 65,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 66,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 67,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 68,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 69,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 70,
                column: "IngredientMeasurement",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 71,
                column: "IngredientMeasurement",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 72,
                column: "IngredientMeasurement",
                value: 0);
        }
    }
}
