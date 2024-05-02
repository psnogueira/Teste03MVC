using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mini_Mundo.Migrations
{
    /// <inheritdoc />
    public partial class Migration09ADM : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NivelDeAcesso",
                columns: table => new
                {
                    NivelDeAcessoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeNivel = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NivelDeAcesso", x => x.NivelDeAcessoID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NivelDeAcesso");
        }
    }
}
