using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreCrud.Migrations
{
    public partial class check : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Country",
                newName: "Currency");

            migrationBuilder.RenameColumn(
                name: "ReleaseDate",
                table: "Country",
                newName: "Travel_Date");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Country",
                newName: "Population");

            migrationBuilder.RenameColumn(
                name: "Genre",
                table: "Country",
                newName: "Country_Name");

            migrationBuilder.AddColumn<string>(
                name: "Capital",
                table: "Country",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isIsland",
                table: "Country",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Capital",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "isIsland",
                table: "Country");

            migrationBuilder.RenameColumn(
                name: "Travel_Date",
                table: "Country",
                newName: "ReleaseDate");

            migrationBuilder.RenameColumn(
                name: "Population",
                table: "Country",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "Currency",
                table: "Country",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Country_Name",
                table: "Country",
                newName: "Genre");
        }
    }
}
