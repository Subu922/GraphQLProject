using Microsoft.EntityFrameworkCore.Migrations;

namespace GraphQLProject.Migrations
{
    public partial class SeedMenusTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Tasty Vada Pav", "Vada Pav", 20.0 },
                    { 2, "Tasty Samosa", "Samosa", 25.0 },
                    { 3, "Tasty Sada Dosa", "Sada Dosa", 30.0 },
                    { 4, "Tasty Masala Dosa", "Masala Dosa", 50.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
