using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRepair.Data.Migrations
{
    public partial class _2test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ModelId",
                table: "Model",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "GearId",
                table: "Gear",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "EngineId",
                table: "EngineCapacity",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "BrandId",
                table: "Brand",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Model",
                newName: "ModelId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Gear",
                newName: "GearId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "EngineCapacity",
                newName: "EngineId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Brand",
                newName: "BrandId");
        }
    }
}
