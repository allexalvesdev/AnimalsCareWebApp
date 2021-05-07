using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppVeterinaria.Migrations
{
    public partial class AddTabelasServicoeAnimal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(50)", nullable: true),
                    Raca = table.Column<string>(type: "varchar(50)", nullable: true),
                    Idade = table.Column<string>(type: "varchar(50)", nullable: true),
                    Peso = table.Column<string>(type: "varchar(50)", nullable: true),
                    Observacao = table.Column<string>(type: "varchar(250)", nullable: true),
                    TipoSexo = table.Column<int>(type: "int", nullable: false),
                    TipoEspecie = table.Column<int>(type: "int", nullable: false),
                    TipoPelo = table.Column<int>(type: "int", nullable: false),
                    Nascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animais", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Animais_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Servicos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "varchar(500)", nullable: true),
                    Preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicos", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Animais_ClienteId",
                table: "Animais",
                column: "ClienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animais");

            migrationBuilder.DropTable(
                name: "Servicos");
        }
    }
}
