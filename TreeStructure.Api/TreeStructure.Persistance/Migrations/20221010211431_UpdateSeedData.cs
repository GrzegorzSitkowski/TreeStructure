using Microsoft.EntityFrameworkCore.Migrations;

namespace TreeStructure.Persistance.Migrations
{
    public partial class UpdateSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Nodes",
                keyColumn: "Id",
                keyValue: 12,
                column: "ParentId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Nodes",
                keyColumn: "Id",
                keyValue: 13,
                column: "ParentId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Nodes",
                keyColumn: "Id",
                keyValue: 14,
                column: "ParentId",
                value: 12);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Nodes",
                keyColumn: "Id",
                keyValue: 12,
                column: "ParentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Nodes",
                keyColumn: "Id",
                keyValue: 13,
                column: "ParentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Nodes",
                keyColumn: "Id",
                keyValue: 14,
                column: "ParentId",
                value: 2);
        }
    }
}
