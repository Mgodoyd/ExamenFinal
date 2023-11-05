using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Examen_final_DW.Migrations
{
    /// <inheritdoc />
    public partial class databasev4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "idExpediente",
                table: "Detalles");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "idExpediente",
                table: "Detalles",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
