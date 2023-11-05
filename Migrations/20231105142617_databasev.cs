using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Examen_final_DW.Migrations
{
    /// <inheritdoc />
    public partial class databasev : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expedientes_Detalles_detalleExpedienteId",
                table: "Expedientes");

            migrationBuilder.AlterColumn<int>(
                name: "detalleExpedienteId",
                table: "Expedientes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Expedientes_Detalles_detalleExpedienteId",
                table: "Expedientes",
                column: "detalleExpedienteId",
                principalTable: "Detalles",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expedientes_Detalles_detalleExpedienteId",
                table: "Expedientes");

            migrationBuilder.AlterColumn<int>(
                name: "detalleExpedienteId",
                table: "Expedientes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Expedientes_Detalles_detalleExpedienteId",
                table: "Expedientes",
                column: "detalleExpedienteId",
                principalTable: "Detalles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
