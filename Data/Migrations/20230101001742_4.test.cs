using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRepair.Data.Migrations
{
    public partial class _4test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Car");

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

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Model",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "KM",
                table: "Model",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Model",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "Model",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Model_EngineCapacity_EngineId",
                table: "Model");

            migrationBuilder.DropForeignKey(
                name: "FK_Model_Gear_GearId",
                table: "Model");

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

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Model");

            migrationBuilder.DropColumn(
                name: "KM",
                table: "Model");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Model");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "Model");

            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EngineId = table.Column<int>(type: "int", nullable: false),
                    GearId = table.Column<int>(type: "int", nullable: false),
                    ModelId = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KM = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Car_EngineCapacity_EngineId",
                        column: x => x.EngineId,
                        principalTable: "EngineCapacity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Car_Gear_GearId",
                        column: x => x.GearId,
                        principalTable: "Gear",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Car_Model_ModelId",
                        column: x => x.ModelId,
                        principalTable: "Model",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Car_EngineId",
                table: "Car",
                column: "EngineId");

            migrationBuilder.CreateIndex(
                name: "IX_Car_GearId",
                table: "Car",
                column: "GearId");

            migrationBuilder.CreateIndex(
                name: "IX_Car_ModelId",
                table: "Car",
                column: "ModelId");
        }
    }
}
