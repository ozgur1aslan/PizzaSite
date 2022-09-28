using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaSite.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_AspNetUsersId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Pizzas_PizzasModelId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "OrderModel");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_PizzasModelId",
                table: "OrderModel",
                newName: "IX_OrderModel_PizzasModelId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_AspNetUsersId",
                table: "OrderModel",
                newName: "IX_OrderModel_AspNetUsersId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderModel",
                table: "OrderModel",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderModel_AspNetUsers_AspNetUsersId",
                table: "OrderModel",
                column: "AspNetUsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderModel_Pizzas_PizzasModelId",
                table: "OrderModel",
                column: "PizzasModelId",
                principalTable: "Pizzas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderModel_AspNetUsers_AspNetUsersId",
                table: "OrderModel");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderModel_Pizzas_PizzasModelId",
                table: "OrderModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderModel",
                table: "OrderModel");

            migrationBuilder.RenameTable(
                name: "OrderModel",
                newName: "Orders");

            migrationBuilder.RenameIndex(
                name: "IX_OrderModel_PizzasModelId",
                table: "Orders",
                newName: "IX_Orders_PizzasModelId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderModel_AspNetUsersId",
                table: "Orders",
                newName: "IX_Orders_AspNetUsersId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_AspNetUsersId",
                table: "Orders",
                column: "AspNetUsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Pizzas_PizzasModelId",
                table: "Orders",
                column: "PizzasModelId",
                principalTable: "Pizzas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
