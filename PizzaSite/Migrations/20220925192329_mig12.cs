using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaSite.Migrations
{
    public partial class mig12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "date",
                table: "Suggestions",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "content",
                table: "Suggestions",
                newName: "Content");

            migrationBuilder.RenameColumn(
                name: "date",
                table: "Orders",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "date",
                table: "DrinkOrders",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "date",
                table: "CustomOrders",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "date",
                table: "Complaints",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "content",
                table: "Complaints",
                newName: "Content");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Suggestions",
                newName: "date");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Suggestions",
                newName: "content");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Orders",
                newName: "date");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "DrinkOrders",
                newName: "date");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "CustomOrders",
                newName: "date");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Complaints",
                newName: "date");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Complaints",
                newName: "content");
        }
    }
}
