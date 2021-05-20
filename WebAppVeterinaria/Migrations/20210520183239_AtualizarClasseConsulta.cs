using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppVeterinaria.Migrations
{
    public partial class AtualizarClasseConsulta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NomeAnimal",
                table: "Consultas");

            migrationBuilder.RenameColumn(
                name: "Raca",
                table: "Consultas",
                newName: "Raca");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Raca",
                table: "Consultas",
                newName: "Raca");

            migrationBuilder.AddColumn<string>(
                name: "NomeAnimal",
                table: "Consultas",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
