using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalonTurnos.Api.Migrations
{
    /// <inheritdoc />
    public partial class CambioEstadoTurnoBool : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Turnos");

            migrationBuilder.AddColumn<bool>(
                name: "Disponible",
                table: "Turnos",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Disponible",
                table: "Turnos");

            migrationBuilder.AddColumn<int>(
                name: "Estado",
                table: "Turnos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
