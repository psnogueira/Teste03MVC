using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mini_Mundo.Migrations
{
    /// <inheritdoc />
    public partial class segundaMigrationADM : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Funcionario",
                columns: table => new
                {
                    FuncionarioID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrimeiroNome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UltimoNome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DtCad = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Salario = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Cargo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NivelDeAcessoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionario", x => x.FuncionarioID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Funcionario");
        }
    }
}
