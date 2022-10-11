using Microsoft.EntityFrameworkCore.Migrations;

namespace TreeStructure.Persistance.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Text",
                table: "Leafs");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Leafs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "Leafs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Leafs",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
