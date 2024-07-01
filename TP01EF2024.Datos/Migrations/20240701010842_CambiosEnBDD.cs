using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TP01EF2024.Datos.Migrations
{
    /// <inheritdoc />
    public partial class CambiosEnBDD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "ShoeId",
                keyValue: 1,
                columns: new[] { "Description", "Model" },
                values: new object[] { "Vans", "Calle" });

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "ShoeId",
                keyValue: 2,
                columns: new[] { "Description", "Model" },
                values: new object[] { "Botas de Lluvia ", "Botas" });

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "ShoeId",
                keyValue: 3,
                columns: new[] { "Description", "Model" },
                values: new object[] { "Facheritas", "Fire" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "ShoeId",
                keyValue: 1,
                columns: new[] { "Description", "Model" },
                values: new object[] { "Vans Deportivas", "Deportivas" });

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "ShoeId",
                keyValue: 2,
                columns: new[] { "Description", "Model" },
                values: new object[] { "Botines Femeninos", "Botines" });

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "ShoeId",
                keyValue: 3,
                columns: new[] { "Description", "Model" },
                values: new object[] { "Importados", "1982" });
        }
    }
}
