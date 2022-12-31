using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRepair.Data.Migrations
{
    public partial class _1test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_EngineCapacity_CategoryId",
                table: "Car");

            migrationBuilder.DropForeignKey(
                name: "FK_Car_Gear_CategoryId",
                table: "Car");

            migrationBuilder.DropForeignKey(
                name: "FK_Car_Model_CategoryId",
                table: "Car");

            migrationBuilder.DropForeignKey(
                name: "FK_Model_Brand_CategoryId",
                table: "Model");

            migrationBuilder.DropIndex(
                name: "IX_Model_CategoryId",
                table: "Model");

            migrationBuilder.DropIndex(
                name: "IX_Car_CategoryId",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Model");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Car");

            migrationBuilder.CreateIndex(
                name: "IX_Model_BrandId",
                table: "Model",
                column: "BrandId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Car_EngineCapacity_EngineId",
                table: "Car",
                column: "EngineId",
                principalTable: "EngineCapacity",
                principalColumn: "EngineId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Gear_GearId",
                table: "Car",
                column: "GearId",
                principalTable: "Gear",
                principalColumn: "GearId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Model_ModelId",
                table: "Car",
                column: "ModelId",
                principalTable: "Model",
                principalColumn: "ModelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Model_Brand_BrandId",
                table: "Model",
                column: "BrandId",
                principalTable: "Brand",
                principalColumn: "BrandId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_EngineCapacity_EngineId",
                table: "Car");

            migrationBuilder.DropForeignKey(
                name: "FK_Car_Gear_GearId",
                table: "Car");

            migrationBuilder.DropForeignKey(
                name: "FK_Car_Model_ModelId",
                table: "Car");

            migrationBuilder.DropForeignKey(
                name: "FK_Model_Brand_BrandId",
                table: "Model");

            migrationBuilder.DropIndex(
                name: "IX_Model_BrandId",
                table: "Model");

            migrationBuilder.DropIndex(
                name: "IX_Car_EngineId",
                table: "Car");

            migrationBuilder.DropIndex(
                name: "IX_Car_GearId",
                table: "Car");

            migrationBuilder.DropIndex(
                name: "IX_Car_ModelId",
                table: "Car");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Model",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Car",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Model_CategoryId",
                table: "Model",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Car_CategoryId",
                table: "Car",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Car_EngineCapacity_CategoryId",
                table: "Car",
                column: "CategoryId",
                principalTable: "EngineCapacity",
                principalColumn: "EngineId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Gear_CategoryId",
                table: "Car",
                column: "CategoryId",
                principalTable: "Gear",
                principalColumn: "GearId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Model_CategoryId",
                table: "Car",
                column: "CategoryId",
                principalTable: "Model",
                principalColumn: "ModelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Model_Brand_CategoryId",
                table: "Model",
                column: "CategoryId",
                principalTable: "Brand",
                principalColumn: "BrandId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
