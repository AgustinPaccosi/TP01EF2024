using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TP01EF2024.Datos.Migrations
{
    /// <inheritdoc />
    public partial class CreacionTablaShoesColours : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "IX_ShoesColours_ColourId",
                table: "shoesColours",
                column: "ColourId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "shoesColours");
        }
    }
}
