using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreCrud.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Capital",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "Currency",
                table: "Country");

            migrationBuilder.RenameColumn(
                name: "isIsland",
                table: "Country",
                newName: "isAvailable");

            migrationBuilder.RenameColumn(
                name: "Population",
                table: "Country",
                newName: "Travel_Cost");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isAvailable",
                table: "Country",
                newName: "isIsland");

            migrationBuilder.RenameColumn(
                name: "Travel_Cost",
                table: "Country",
                newName: "Population");

            migrationBuilder.AddColumn<string>(
                name: "Capital",
                table: "Country",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Currency",
                table: "Country",
                nullable: true);
        }
    }
}
