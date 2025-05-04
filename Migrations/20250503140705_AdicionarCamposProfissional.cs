using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgendamentoAPI.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarCamposProfissional : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "profissionais",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "profissionais",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "cpf",
                table: "profissionais",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "profissionais");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "profissionais");

            migrationBuilder.DropColumn(
                name: "cpf",
                table: "profissionais");
        }
    }
}
