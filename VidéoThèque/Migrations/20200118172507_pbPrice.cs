using Microsoft.EntityFrameworkCore.Migrations;

namespace VidéoThèque.Migrations
{
    public partial class pbPrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "prixDuFilm",
                table: "Commande",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "prixDuFilm",
                table: "Commande");
        }
    }
}
