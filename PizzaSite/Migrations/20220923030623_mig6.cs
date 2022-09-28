using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PizzaSite.Migrations
{
    public partial class mig6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "CustomOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AspNetUsersId = table.Column<string>(type: "text", nullable: false),
                    PizzasModelPizzaName = table.Column<string>(type: "text", nullable: false),
                    PizzasModelFinalPrice = table.Column<int>(type: "integer", nullable: false),
                    TomatoSauce = table.Column<bool>(type: "boolean", nullable: false),
                    Cheese = table.Column<bool>(type: "boolean", nullable: false),
                    Peperoni = table.Column<bool>(type: "boolean", nullable: false),
                    Mushroom = table.Column<bool>(type: "boolean", nullable: false),
                    Tuna = table.Column<bool>(type: "boolean", nullable: false),
                    Pineapple = table.Column<bool>(type: "boolean", nullable: false),
                    Ham = table.Column<bool>(type: "boolean", nullable: false),
                    Beef = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomOrders_AspNetUsers_AspNetUsersId",
                        column: x => x.AspNetUsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomOrders_Pizzas_PizzasModelFinalPrice",
                        column: x => x.PizzasModelFinalPrice,
                        principalTable: "Pizzas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomOrders_AspNetUsersId",
                table: "CustomOrders",
                column: "AspNetUsersId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomOrders_PizzasModelFinalPrice",
                table: "CustomOrders",
                column: "PizzasModelFinalPrice");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_AspNetUsersId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Pizzas_PizzasModelId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "CustomOrders");

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
    }
}
