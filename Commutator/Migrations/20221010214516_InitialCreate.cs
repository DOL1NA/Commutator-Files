using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Commutator.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    IP = table.Column<string>(nullable: true),
                    Mac = table.Column<string>(nullable: true),
                    VLAN = table.Column<string>(nullable: true),
                    Sern = table.Column<string>(nullable: true),
                    Invn = table.Column<string>(nullable: true),
                    BuyDate = table.Column<DateTime>(nullable: false),
                    UstDate = table.Column<DateTime>(nullable: false),
                    Atug = table.Column<int>(nullable: false),
                    Koment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie");
        }
    }
}
