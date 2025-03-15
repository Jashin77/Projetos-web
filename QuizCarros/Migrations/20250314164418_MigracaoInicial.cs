using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizCarros.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "perguntas",
                columns: table => new
                {
                    PerguntasId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Enunciado = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Alternativa1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Alternativa2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Alternativa3 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Alternativa4 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    RespostaCorreta = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_perguntas", x => x.PerguntasId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "perguntas");
        }
    }
}
