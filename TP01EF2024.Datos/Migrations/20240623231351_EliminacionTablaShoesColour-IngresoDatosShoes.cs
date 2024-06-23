using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TP01EF2024.Datos.Migrations
{
    /// <inheritdoc />
    public partial class EliminacionTablaShoesColourIngresoDatosShoes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "shoesColours");

            migrationBuilder.AddColumn<int>(
                name: "ColourId",
                table: "Shoes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Shoes",
                columns: new[] { "ShoeId", "BrandId", "ColourId", "Description", "GenreId", "Model", "Price", "SportId" },
                values: new object[,]
                {
                    { 1, 1, 1, "Vans Deportivas", 2, "Deportivas", 15m, 3 },
                    { 2, 2, 1, "Botines Femeninos", 1, "Botines", 20m, 1 },
                    { 3, 3, 1, "Importados", 3, "1982", 35m, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Shoes_ColourId",
                table: "Shoes",
                column: "ColourId");

            migrationBuilder.AddForeignKey(
                name: "FK_Shoes_Colours_ColourId",
                table: "Shoes",
                column: "ColourId",
                principalTable: "Colours",
                principalColumn: "ColourId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shoes_Colours_ColourId",
                table: "Shoes");

            migrationBuilder.DropIndex(
                name: "IX_Shoes_ColourId",
                table: "Shoes");

            migrationBuilder.DeleteData(
                table: "Shoes",
                keyColumn: "ShoeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Shoes",
                keyColumn: "ShoeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Shoes",
                keyColumn: "ShoeId",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "ColourId",
                table: "Shoes");

            migrationBuilder.CreateTable(
                name: "shoesColours",
                columns: table => new
                {
                    ShoeId = table.Column<int>(type: "int", nullable: false),
                    ColourId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shoesColours", x => new { x.ShoeId, x.ColourId });
                    table.ForeignKey(
                        name: "FK_shoesColours_Colours_ColourId",
                        column: x => x.ColourId,
                        principalTable: "Colours",
                        principalColumn: "ColourId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_shoesColours_Shoes_ShoeId",
                        column: x => x.ShoeId,
                        principalTable: "Shoes",
                        principalColumn: "ShoeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_shoesColours_ColourId",
                table: "shoesColours",
                column: "ColourId");
        }
    }
}
