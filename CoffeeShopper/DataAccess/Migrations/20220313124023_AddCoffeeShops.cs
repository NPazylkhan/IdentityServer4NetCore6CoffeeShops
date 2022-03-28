using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class AddCoffeeShops : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($"Insert INTO CoffeeShops(Name, OpeningHours, Address) Values(" +
                $"'TopBarista', '9-5 Mon-Sat', 'Koktem 3')");
            migrationBuilder.Sql($"Insert INTO CoffeeShops(Name, OpeningHours, Address) Values(" +
                $"'StarBucks', '9-5 Mon-Sat', 'Al-Farabi 77')");
            migrationBuilder.Sql($"Insert INTO CoffeeShops(Name, OpeningHours, Address) Values(" +
                $"'Centeral Coffee', '9-5 Mon-Sat', 'Dostyq')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
