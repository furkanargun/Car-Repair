using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRepair.Data.Migrations
{
    public partial class _8test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KM",
                table: "Model");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Model");

            migrationBuilder.RenameColumn(
                name: "Year",
                table: "Model",
                newName: "BrandID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Model",
                newName: "ModelID");

            migrationBuilder.CreateTable(
                name: "Brand",
                columns: table => new
                {
                    BrandID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brand", x => x.BrandID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Model_BrandID",
                table: "Model",
                column: "BrandID");

            migrationBuilder.AddForeignKey(
                name: "FK_Model_Brand_BrandID",
                table: "Model",
                column: "BrandID",
                principalTable: "Brand",
                principalColumn: "BrandID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Model_Brand_BrandID",
                table: "Model");

            migrationBuilder.DropTable(
                name: "Brand");

            migrationBuilder.DropIndex(
                name: "IX_Model_BrandID",
                table: "Model");

            migrationBuilder.RenameColumn(
                name: "BrandID",
                table: "Model",
                newName: "Year");

            migrationBuilder.RenameColumn(
                name: "ModelID",
                table: "Model",
                newName: "Id");

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
        }
    }
}
