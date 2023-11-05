using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Examen_final_DW.Migrations
{
    /// <inheritdoc />
    public partial class databasev7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expedientes_Detalles_detalleExpedienteId",
                table: "Expedientes");

            migrationBuilder.DropColumn(
                name: "idExpedientes",
                table: "Detalles");

            migrationBuilder.RenameColumn(
                name: "detalleExpedienteId",
                table: "Expedientes",
                newName: "IdExpedientes");

            migrationBuilder.RenameIndex(
                name: "IX_Expedientes_detalleExpedienteId",
                table: "Expedientes",
                newName: "IX_Expedientes_IdExpedientes");

            migrationBuilder.AddForeignKey(
                name: "FK_Expedientes_Detalles_IdExpedientes",
                table: "Expedientes",
                column: "IdExpedientes",
                principalTable: "Detalles",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expedientes_Detalles_IdExpedientes",
                table: "Expedientes");

            migrationBuilder.RenameColumn(
                name: "IdExpedientes",
                table: "Expedientes",
                newName: "detalleExpedienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Expedientes_IdExpedientes",
                table: "Expedientes",
                newName: "IX_Expedientes_detalleExpedienteId");

            migrationBuilder.AddColumn<int>(
                name: "idExpedientes",
                table: "Detalles",
                type: "int",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Expedientes_Detalles_detalleExpedienteId",
                table: "Expedientes",
                column: "detalleExpedienteId",
                principalTable: "Detalles",
                principalColumn: "Id");
        }
    }
}
