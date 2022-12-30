using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankTransactions.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gazliceceks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marka = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Tur = table.Column<string>(type: "nvarchar(12)", nullable: false),
                    Boyut = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Detail = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Seker = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Calories = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Carbohydrates = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Ulke = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    Ozellik1 = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    Ozellik2 = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    Ozellik3 = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    KYili = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IcecekPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IcecekFileName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gazliceceks", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gazliceceks");
        }
    }
}
