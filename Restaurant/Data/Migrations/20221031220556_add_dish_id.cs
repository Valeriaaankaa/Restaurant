using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class add_dish_id : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Amount", "DishId", "ExpirationDate", "ImportDate", "Name", "Price" },
                values: new object[] { 1, 1m, 1, new DateTime(2011, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Water", 5m });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Amount", "DishId", "ExpirationDate", "ImportDate", "Name", "Price" },
                values: new object[] { 2, 1m, 2, new DateTime(2011, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beer", 5m });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Amount", "DishId", "ExpirationDate", "ImportDate", "Name", "Price" },
                values: new object[] { 3, 1m, 3, new DateTime(2011, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Milk", 5m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
