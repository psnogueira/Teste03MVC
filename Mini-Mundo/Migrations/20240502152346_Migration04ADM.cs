using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mini_Mundo.Migrations
{
    /// <inheritdoc />
    public partial class Migration04ADM : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Cargo",
                table: "Funcionario",
                newName: "CargoID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CargoID",
                table: "Funcionario",
                newName: "Cargo");
        }
    }
}
