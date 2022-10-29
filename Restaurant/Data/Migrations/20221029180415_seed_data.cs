using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class seed_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Amount", "ExpirationDate", "ImportDate", "Name", "Price" },
                values: new object[] { 1, 1m, new DateTime(2011, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Water", 5m });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Amount", "ExpirationDate", "ImportDate", "Name", "Price" },
                values: new object[] { 2, 1m, new DateTime(2011, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beer", 5m });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Amount", "ExpirationDate", "ImportDate", "Name", "Price" },
                values: new object[] { 3, 1m, new DateTime(2011, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Milk", 5m });
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
