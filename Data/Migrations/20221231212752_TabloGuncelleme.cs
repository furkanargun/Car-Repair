using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRepair.Data.Migrations
{
    public partial class TabloGuncelleme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Brand_Model_ModelId",
                table: "Brand");

            migrationBuilder.DropForeignKey(
                name: "FK_Car_Brand_BrandId",
                table: "Car");

            migrationBuilder.DropTable(
                name: "Color");

            migrationBuilder.DropTable(
                name: "KM");

            migrationBuilder.DropIndex(
                name: "IX_Brand_ModelId",
                table: "Brand");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "Model");

            migrationBuilder.DropColumn(
                name: "EngineCapacity",
                table: "Model");

            migrationBuilder.DropColumn(
                name: "CarBrand",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "EngineCapacity",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "Gear",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "ModelId",
                table: "Brand");

            migrationBuilder.RenameColumn(
                name: "BrandId",
                table: "Car",
                newName: "ModelId");

            migrationBuilder.RenameIndex(
                name: "IX_Car_BrandId",
                table: "Car",
                newName: "IX_Car_ModelId");

            migrationBuilder.AddColumn<int>(
                name: "BrandId",
                table: "Model",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EngineCapacityEngineId",
                table: "Car",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EngineId",
                table: "Car",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GearId",
                table: "Car",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "BrandName",
                table: "Brand",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Model_BrandId",
                table: "Model",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Car_EngineCapacityEngineId",
                table: "Car",
                column: "EngineCapacityEngineId");

            migrationBuilder.CreateIndex(
                name: "IX_Car_GearId",
                table: "Car",
                column: "GearId");

            migrationBuilder.AddForeignKey(
                name: "FK_Car_EngineCapacity_EngineCapacityEngineId",
                table: "Car",
                column: "EngineCapacityEngineId",
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
                name: "FK_Car_EngineCapacity_EngineCapacityEngineId",
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
                name: "IX_Car_EngineCapacityEngineId",
                table: "Car");

            migrationBuilder.DropIndex(
                name: "IX_Car_GearId",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "Model");

            migrationBuilder.DropColumn(
                name: "EngineCapacityEngineId",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "EngineId",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "GearId",
                table: "Car");

            migrationBuilder.RenameColumn(
                name: "ModelId",
                table: "Car",
                newName: "BrandId");

            migrationBuilder.RenameIndex(
                name: "IX_Car_ModelId",
                table: "Car",
                newName: "IX_Car_BrandId");

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Model",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "EngineCapacity",
                table: "Model",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "CarBrand",
                table: "Car",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "EngineCapacity",
                table: "Car",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Gear",
                table: "Car",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Car",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BrandName",
                table: "Brand",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "ModelId",
                table: "Brand",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Color",
                columns: table => new
                {
                    ColorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColorName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Color", x => x.ColorId);
                });

            migrationBuilder.CreateTable(
                name: "KM",
                columns: table => new
                {
                    KmId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Km = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KM", x => x.KmId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Brand_ModelId",
                table: "Brand",
                column: "ModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Brand_Model_ModelId",
                table: "Brand",
                column: "ModelId",
                principalTable: "Model",
                principalColumn: "ModelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Brand_BrandId",
                table: "Car",
                column: "BrandId",
                principalTable: "Brand",
                principalColumn: "BrandId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
