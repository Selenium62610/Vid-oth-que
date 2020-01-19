using System;
using Microsoft.EntityFrameworkCore.Migrations;
using VidéoThèque.Models;

namespace VidéoThèque.Migrations
{
    public partial class Commande : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Commande",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDmovie = table.Column<int>(nullable: false),
                    dureeLocation = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commande", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Commande");
        }

        public static implicit operator Commande(Models.Commande v)
        {
            throw new NotImplementedException();
        }
    }
}
