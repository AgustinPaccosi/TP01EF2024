using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TP01EF2024.Datos.Migrations
{
    /// <inheritdoc />
    public partial class CreacionTablaShoeSizeCampoActive : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoeSize_Shoes_ShoeId",
                table: "ShoeSize");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoeSize_Sizes_SizeId",
                table: "ShoeSize");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoeSize",
                table: "ShoeSize");

            migrationBuilder.DropIndex(
                name: "IX_ShoeSize_ShoeId",
                table: "ShoeSize");

            migrationBuilder.RenameTable(
                name: "ShoeSize",
                newName: "ShoesSizes");

            migrationBuilder.RenameIndex(
                name: "IX_ShoeSize_SizeId",
                table: "ShoesSizes",
                newName: "IX_ShoesSizes_SizeId");

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Sports",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Shoes",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Colours",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Brands",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoesSizes",
                table: "ShoesSizes",
                column: "ShoeSizeId");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 1,
                column: "Active",
                value: true);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 2,
                column: "Active",
                value: true);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 3,
                column: "Active",
                value: true);

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "ColourId",
                keyValue: 1,
                column: "Active",
                value: true);

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "ColourId",
                keyValue: 2,
                column: "Active",
                value: true);

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "ColourId",
                keyValue: 3,
                column: "Active",
                value: true);

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "ShoeId",
                keyValue: 1,
                column: "Active",
                value: true);

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "ShoeId",
                keyValue: 2,
                column: "Active",
                value: true);

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "ShoeId",
                keyValue: 3,
                column: "Active",
                value: true);

            migrationBuilder.UpdateData(
                table: "Sports",
                keyColumn: "SportId",
                keyValue: 1,
                column: "Active",
                value: true);

            migrationBuilder.UpdateData(
                table: "Sports",
                keyColumn: "SportId",
                keyValue: 2,
                column: "Active",
                value: true);

            migrationBuilder.UpdateData(
                table: "Sports",
                keyColumn: "SportId",
                keyValue: 3,
                column: "Active",
                value: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShoesSizes_ShoeId_SizeId",
                table: "ShoesSizes",
                columns: new[] { "ShoeId", "SizeId" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoesSizes_Shoes_ShoeId",
                table: "ShoesSizes",
                column: "ShoeId",
                principalTable: "Shoes",
                principalColumn: "ShoeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoesSizes_Sizes_SizeId",
                table: "ShoesSizes",
                column: "SizeId",
                principalTable: "Sizes",
                principalColumn: "SizeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoesSizes_Shoes_ShoeId",
                table: "ShoesSizes");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoesSizes_Sizes_SizeId",
                table: "ShoesSizes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoesSizes",
                table: "ShoesSizes");

            migrationBuilder.DropIndex(
                name: "IX_ShoesSizes_ShoeId_SizeId",
                table: "ShoesSizes");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Sports");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Shoes");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Colours");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Brands");

            migrationBuilder.RenameTable(
                name: "ShoesSizes",
                newName: "ShoeSize");

            migrationBuilder.RenameIndex(
                name: "IX_ShoesSizes_SizeId",
                table: "ShoeSize",
                newName: "IX_ShoeSize_SizeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoeSize",
                table: "ShoeSize",
                column: "ShoeSizeId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoeSize_ShoeId",
                table: "ShoeSize",
                column: "ShoeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoeSize_Shoes_ShoeId",
                table: "ShoeSize",
                column: "ShoeId",
                principalTable: "Shoes",
                principalColumn: "ShoeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoeSize_Sizes_SizeId",
                table: "ShoeSize",
                column: "SizeId",
                principalTable: "Sizes",
                principalColumn: "SizeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
