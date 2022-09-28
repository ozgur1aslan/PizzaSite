using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaSite.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Beef",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Cheese",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Ham",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Mushroom",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Peperoni",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Pineapple",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "TomatoSauce",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Tuna",
                table: "Orders");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Beef",
                table: "Orders",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Cheese",
                table: "Orders",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Ham",
                table: "Orders",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Mushroom",
                table: "Orders",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Peperoni",
                table: "Orders",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Pineapple",
                table: "Orders",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "TomatoSauce",
                table: "Orders",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Tuna",
                table: "Orders",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }
    }
}
