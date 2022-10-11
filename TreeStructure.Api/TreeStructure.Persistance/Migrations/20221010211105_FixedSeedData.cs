using Microsoft.EntityFrameworkCore.Migrations;

namespace TreeStructure.Persistance.Migrations
{
    public partial class FixedSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Nodes",
                columns: new[] { "Id", "Name", "ParentId", "TreeNodeId" },
                values: new object[,]
                {
                    { 11, "FirstNode", 0, null },
                    { 12, "SecondNode", 1, null },
                    { 13, "ThirdNode", 1, null },
                    { 14, "FourthNode", 2, null }
                });

            migrationBuilder.InsertData(
                table: "Leafs",
                columns: new[] { "Id", "LeafId", "LeafParentId", "Name", "ParentId" },
                values: new object[,]
                {
                    { 21, null, null, "FirstLeaf", 11 },
                    { 22, null, null, "SecondLeaf", 11 },
                    { 23, null, null, "ThirdLeaf", 12 },
                    { 24, null, 23, "FourthLeaf", 12 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Leafs",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Leafs",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Leafs",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Leafs",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Nodes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Nodes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Nodes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Nodes",
                keyColumn: "Id",
                keyValue: 12);
        }
    }
}
