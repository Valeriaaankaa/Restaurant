using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class changeingredientrelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_Dishes_DishId",
                table: "Ingredients");

            migrationBuilder.DropIndex(
                name: "IX_Ingredients_DishId",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "DishId",
                table: "Ingredients");

            migrationBuilder.CreateTable(
                name: "DishCompositions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DishId = table.Column<int>(type: "int", nullable: false),
                    IngredientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DishCompositions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DishCompositions_Dishes_DishId",
                        column: x => x.DishId,
                        principalTable: "Dishes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DishCompositions_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RestaurantTables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Zone = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantTables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Admins_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TableOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeBegin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RestaurantTableId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TableOrders_RestaurantTables_RestaurantTableId",
                        column: x => x.RestaurantTableId,
                        principalTable: "RestaurantTables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderStatus = table.Column<int>(type: "int", nullable: false),
                    TableOrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_TableOrders_TableOrderId",
                        column: x => x.TableOrderId,
                        principalTable: "TableOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DishOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    DishId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DishOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DishOrders_Dishes_DishId",
                        column: x => x.DishId,
                        principalTable: "Dishes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DishOrders_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RestaurantUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RestaurantUsers_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RestaurantUsers_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DishCompositions",
                columns: new[] { "Id", "Amount", "DishId", "IngredientId" },
                values: new object[,]
                {
                    { 1, 0m, 1, 1 },
                    { 2, 0m, 1, 2 },
                    { 3, 0m, 3, 3 }
                });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Amount", "ExpirationDate", "ImportDate" },
                values: new object[] { 23m, new DateTime(2021, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Amount", "ExpirationDate", "ImportDate", "IngredientGroup", "Name", "Price" },
                values: new object[] { 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Amount", "ExpirationDate", "ImportDate", "IngredientGroup", "Name", "Price" },
                values: new object[] { 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Amount", "ExpirationDate", "ImportDate", "IngredientGroup", "Name", "Price" },
                values: new object[,]
                {
                    { 4, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 5, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 6, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 7, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 8, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 9, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 10, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 11, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 12, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 13, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 14, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 15, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 16, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 17, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 18, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 19, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 20, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 21, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 22, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 23, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 24, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 25, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 26, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 27, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 28, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 29, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 30, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 31, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 32, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 33, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 34, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 35, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 36, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 37, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 38, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 39, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Amount", "ExpirationDate", "ImportDate", "IngredientGroup", "Name", "Price" },
                values: new object[,]
                {
                    { 40, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 41, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 42, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 43, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 44, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 45, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 46, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 47, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 48, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 49, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 50, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 51, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 52, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 53, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 54, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 55, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 56, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 57, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 58, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 59, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 60, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 61, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 62, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 63, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 64, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 65, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 66, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 67, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 68, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 69, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 70, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 71, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m },
                    { 72, 10m, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pork", 150m }
                });

            migrationBuilder.InsertData(
                table: "DishCompositions",
                columns: new[] { "Id", "Amount", "DishId", "IngredientId" },
                values: new object[,]
                {
                    { 4, 0m, 4, 4 },
                    { 5, 0m, 5, 5 },
                    { 6, 0m, 6, 6 },
                    { 7, 0m, 7, 7 },
                    { 8, 0m, 8, 8 },
                    { 9, 0m, 9, 9 },
                    { 10, 0m, 10, 10 },
                    { 11, 0m, 11, 11 },
                    { 12, 0m, 12, 12 },
                    { 13, 0m, 13, 13 },
                    { 14, 0m, 14, 14 },
                    { 15, 0m, 15, 15 },
                    { 16, 0m, 16, 16 },
                    { 17, 0m, 17, 17 },
                    { 18, 0m, 18, 18 },
                    { 19, 0m, 19, 19 },
                    { 20, 0m, 20, 20 },
                    { 21, 0m, 21, 21 },
                    { 22, 0m, 22, 22 },
                    { 23, 0m, 23, 23 },
                    { 24, 0m, 24, 24 },
                    { 25, 0m, 25, 25 },
                    { 26, 0m, 26, 26 },
                    { 27, 0m, 27, 27 },
                    { 28, 0m, 28, 28 },
                    { 29, 0m, 29, 29 },
                    { 30, 0m, 30, 30 },
                    { 31, 0m, 31, 31 },
                    { 32, 0m, 32, 32 },
                    { 33, 0m, 33, 33 },
                    { 34, 0m, 34, 34 },
                    { 35, 0m, 35, 35 },
                    { 36, 0m, 36, 36 },
                    { 37, 0m, 37, 37 },
                    { 38, 0m, 38, 38 },
                    { 39, 0m, 39, 39 },
                    { 40, 0m, 40, 40 },
                    { 41, 0m, 41, 41 },
                    { 42, 0m, 42, 42 },
                    { 43, 0m, 43, 43 },
                    { 44, 0m, 44, 44 },
                    { 45, 0m, 45, 45 }
                });

            migrationBuilder.InsertData(
                table: "DishCompositions",
                columns: new[] { "Id", "Amount", "DishId", "IngredientId" },
                values: new object[,]
                {
                    { 46, 0m, 46, 46 },
                    { 47, 0m, 47, 47 },
                    { 48, 0m, 48, 48 },
                    { 49, 0m, 49, 49 },
                    { 50, 0m, 50, 50 },
                    { 51, 0m, 51, 51 },
                    { 52, 0m, 52, 52 },
                    { 53, 0m, 53, 53 },
                    { 54, 0m, 54, 54 },
                    { 55, 0m, 55, 55 },
                    { 56, 0m, 56, 56 },
                    { 57, 0m, 57, 57 },
                    { 58, 0m, 58, 58 },
                    { 59, 0m, 59, 59 },
                    { 60, 0m, 60, 60 },
                    { 61, 0m, 61, 61 },
                    { 62, 0m, 62, 62 },
                    { 63, 0m, 63, 63 },
                    { 64, 0m, 64, 64 },
                    { 65, 0m, 65, 65 },
                    { 66, 0m, 66, 66 },
                    { 67, 0m, 67, 67 },
                    { 68, 0m, 68, 68 },
                    { 69, 0m, 69, 69 },
                    { 70, 0m, 70, 70 },
                    { 71, 0m, 71, 71 },
                    { 72, 0m, 72, 72 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Admins_PersonId",
                table: "Admins",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_DishCompositions_DishId",
                table: "DishCompositions",
                column: "DishId");

            migrationBuilder.CreateIndex(
                name: "IX_DishCompositions_IngredientId",
                table: "DishCompositions",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_DishOrders_DishId",
                table: "DishOrders",
                column: "DishId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DishOrders_OrderId",
                table: "DishOrders",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_TableOrderId",
                table: "Orders",
                column: "TableOrderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantUsers_OrderId",
                table: "RestaurantUsers",
                column: "OrderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantUsers_PersonId",
                table: "RestaurantUsers",
                column: "PersonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TableOrders_RestaurantTableId",
                table: "TableOrders",
                column: "RestaurantTableId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "DishCompositions");

            migrationBuilder.DropTable(
                name: "DishOrders");

            migrationBuilder.DropTable(
                name: "RestaurantUsers");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "TableOrders");

            migrationBuilder.DropTable(
                name: "RestaurantTables");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.AddColumn<int>(
                name: "DishId",
                table: "Ingredients",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Amount", "ExpirationDate", "ImportDate" },
                values: new object[] { 1m, new DateTime(2011, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Amount", "ExpirationDate", "ImportDate", "IngredientGroup", "Name", "Price" },
                values: new object[] { 1m, new DateTime(2011, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Beer", 5m });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Amount", "ExpirationDate", "ImportDate", "IngredientGroup", "Name", "Price" },
                values: new object[] { 1m, new DateTime(2011, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Milk", 5m });

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_DishId",
                table: "Ingredients",
                column: "DishId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_Dishes_DishId",
                table: "Ingredients",
                column: "DishId",
                principalTable: "Dishes",
                principalColumn: "Id");
        }
    }
}
