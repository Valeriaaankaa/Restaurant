using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class reservationtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ReservationDate",
                table: "Reservations",
                type: "date",
                nullable: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "TimeBegin",
                table: "Reservations",
                type: "time",
                nullable: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "TimeEnd",
                table: "Reservations",
                type: "time",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReservationDate",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "TimeBegin",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "TimeEnd",
                table: "Reservations");
        }
    }
}
