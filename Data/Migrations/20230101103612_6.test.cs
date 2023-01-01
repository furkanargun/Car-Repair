using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRepair.Data.Migrations
{
    public partial class _6test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Model_EngineCapacity_EngineId",
                table: "Model");

            migrationBuilder.DropForeignKey(
                name: "FK_Model_Gear_GearId",
                table: "Model");

            migrationBuilder.DropTable(
                name: "EngineCapacity");

            migrationBuilder.DropTable(
                name: "Gear");

            migrationBuilder.DropIndex(
                name: "IX_Model_EngineId",
                table: "Model");

            migrationBuilder.DropIndex(
                name: "IX_Model_GearId",
                table: "Model");

            migrationBuilder.DropColumn(
                name: "EngineId",
                table: "Model");

            migrationBuilder.DropColumn(
                name: "GearId",
                table: "Model");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EngineId",
                table: "Model",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GearId",
                table: "Model",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "EngineCapacity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Capacity = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EngineCapacity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gear",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GearType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gear", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Model_EngineId",
                table: "Model",
                column: "EngineId");

            migrationBuilder.CreateIndex(
                name: "IX_Model_GearId",
                table: "Model",
                column: "GearId");

            migrationBuilder.AddForeignKey(
                name: "FK_Model_EngineCapacity_EngineId",
                table: "Model",
                column: "EngineId",
                principalTable: "EngineCapacity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Model_Gear_GearId",
                table: "Model",
                column: "GearId",
                principalTable: "Gear",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
