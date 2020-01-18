using Microsoft.EntityFrameworkCore.Migrations;

namespace VidéoThèque.Migrations
{
    public partial class AprèsleMerge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NbLocation",
                table: "Movie",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NbLocation",
                table: "Movie");
        }
    }
}
