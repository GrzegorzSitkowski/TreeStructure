using Microsoft.EntityFrameworkCore.Migrations;

namespace TreeStructure.Persistance.Migrations
{
    public partial class LeafChildren : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LeafId",
                table: "Leafs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LeafParentId",
                table: "Leafs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Leafs_LeafId",
                table: "Leafs",
                column: "LeafId");

            migrationBuilder.AddForeignKey(
                name: "FK_Leafs_Leafs_LeafId",
                table: "Leafs",
                column: "LeafId",
                principalTable: "Leafs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Leafs_Leafs_LeafId",
                table: "Leafs");

            migrationBuilder.DropIndex(
                name: "IX_Leafs_LeafId",
                table: "Leafs");

            migrationBuilder.DropColumn(
                name: "LeafId",
                table: "Leafs");

            migrationBuilder.DropColumn(
                name: "LeafParentId",
                table: "Leafs");
        }
    }
}
