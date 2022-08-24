using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PizzaSite.Migrations
{
    public partial class AddedPizzasToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pizzas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ImageTitle = table.Column<string>(type: "text", nullable: false),
                    PizzaName = table.Column<string>(type: "text", nullable: false),
                    BasePrice = table.Column<float>(type: "real", nullable: false),
                    TomatoSauce = table.Column<bool>(type: "boolean", nullable: false),
                    Cheese = table.Column<bool>(type: "boolean", nullable: false),
                    Peperoni = table.Column<bool>(type: "boolean", nullable: false),
                    Mushroom = table.Column<bool>(type: "boolean", nullable: false),
                    Tuna = table.Column<bool>(type: "boolean", nullable: false),
                    Pineapple = table.Column<bool>(type: "boolean", nullable: false),
                    Ham = table.Column<bool>(type: "boolean", nullable: false),
                    Beef = table.Column<bool>(type: "boolean", nullable: false),
                    FinalPrice = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizzas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pizzas");
        }
    }
}
