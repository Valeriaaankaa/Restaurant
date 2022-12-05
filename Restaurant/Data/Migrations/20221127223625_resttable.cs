using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class resttable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RestCartTables_RestaurantTables_restaurantId",
                table: "RestCartTables");

            migrationBuilder.RenameColumn(
                name: "restaurantId",
                table: "RestCartTables",
                newName: "restaurantTableId");

            migrationBuilder.RenameIndex(
                name: "IX_RestCartTables_restaurantId",
                table: "RestCartTables",
                newName: "IX_RestCartTables_restaurantTableId");

            migrationBuilder.AddForeignKey(
                name: "FK_RestCartTables_RestaurantTables_restaurantTableId",
                table: "RestCartTables",
                column: "restaurantTableId",
                principalTable: "RestaurantTables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RestCartTables_RestaurantTables_restaurantTableId",
                table: "RestCartTables");

            migrationBuilder.RenameColumn(
                name: "restaurantTableId",
                table: "RestCartTables",
                newName: "restaurantId");

            migrationBuilder.RenameIndex(
                name: "IX_RestCartTables_restaurantTableId",
                table: "RestCartTables",
                newName: "IX_RestCartTables_restaurantId");

            migrationBuilder.AddForeignKey(
                name: "FK_RestCartTables_RestaurantTables_restaurantId",
                table: "RestCartTables",
                column: "restaurantId",
                principalTable: "RestaurantTables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
