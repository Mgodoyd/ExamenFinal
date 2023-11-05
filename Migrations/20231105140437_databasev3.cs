using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Examen_final_DW.Migrations
{
    /// <inheritdoc />
    public partial class databasev3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "detalleExpedienteId",
                table: "Expedientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idexpediente",
                table: "Expedientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idExpedientes",
                table: "Detalles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Expedientes_detalleExpedienteId",
                table: "Expedientes",
                column: "detalleExpedienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Expedientes_Detalles_detalleExpedienteId",
                table: "Expedientes",
                column: "detalleExpedienteId",
                principalTable: "Detalles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expedientes_Detalles_detalleExpedienteId",
                table: "Expedientes");

            migrationBuilder.DropIndex(
                name: "IX_Expedientes_detalleExpedienteId",
                table: "Expedientes");

            migrationBuilder.DropColumn(
                name: "detalleExpedienteId",
                table: "Expedientes");

            migrationBuilder.DropColumn(
                name: "idexpediente",
                table: "Expedientes");

            migrationBuilder.DropColumn(
                name: "idExpedientes",
                table: "Detalles");
        }
    }
}
