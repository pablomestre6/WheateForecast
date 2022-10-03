using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WheateForecast.Migrations
{
    public partial class CadastroFuncionario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CadastroFuncionarioModel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Setor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPF = table.Column<int>(type: "int", nullable: false),
                    Identidade = table.Column<int>(type: "int", nullable: false),
                    NumeroTelefone = table.Column<int>(type: "int", nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    CEP = table.Column<int>(type: "int", nullable: false),
                    DataAdmicao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataNacimento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CadastroFuncionarioModel", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CadastroFuncionarioModel");
        }
    }
}
