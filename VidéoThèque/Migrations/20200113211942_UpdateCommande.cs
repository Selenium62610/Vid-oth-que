using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VidéoThèque.Migrations
{
    public partial class UpdateCommande : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IDuser",
                table: "Commande",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "dateLocation",
                table: "Commande",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IDuser",
                table: "Commande");

            migrationBuilder.DropColumn(
                name: "dateLocation",
                table: "Commande");
        }
    }
}
