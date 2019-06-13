using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MegaDesk.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Quote",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true),
                    width = table.Column<double>(nullable: true),
                    depth = table.Column<double>(nullable: true),
                    numOfDrawers = table.Column<int>(nullable: true),
                    price = table.Column<decimal>(nullable: true),
                    material = table.Column<string>(nullable: true),
                    rushOrder = table.Column<string>(nullable: true),
                    DateAdded = table.Column<DateTime>(nullable: false)


        },
                constraints: table =>
                {
                    table.PrimaryKey("PK_name", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Quote");
        }
    }
}
