using Microsoft.EntityFrameworkCore.Migrations;

namespace TreeStructure.Persistance.Migrations
{
    public partial class NodesWithPatern : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TreeNodeId",
                table: "Nodes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Nodes_TreeNodeId",
                table: "Nodes",
                column: "TreeNodeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Nodes_Nodes_TreeNodeId",
                table: "Nodes",
                column: "TreeNodeId",
                principalTable: "Nodes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Nodes_Nodes_TreeNodeId",
                table: "Nodes");

            migrationBuilder.DropIndex(
                name: "IX_Nodes_TreeNodeId",
                table: "Nodes");

            migrationBuilder.DropColumn(
                name: "TreeNodeId",
                table: "Nodes");
        }
    }
}
