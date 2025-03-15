using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizCarros.Migrations
{
    /// <inheritdoc />
    public partial class attImgPerguntas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE perguntas SET ImagemUrl = '/img/baixados.jpeg' WHERE PerguntasId = 1");
            migrationBuilder.Sql("UPDATE perguntas SET ImagemUrl = '/img/Branding Fun_ Ferrari http___marketingisnotselling_com_branding-fun-ferrari_.jpeg' WHERE PerguntasId = 2");
            migrationBuilder.Sql("UPDATE perguntas SET ImagemUrl = '/img/baixados (1).jpeg' WHERE PerguntasId = 3");
            migrationBuilder.Sql("UPDATE perguntas SET ImagemUrl = '/img/Classic Ford Mustang in the Wild.jpeg' WHERE PerguntasId = 4");
            migrationBuilder.Sql("UPDATE perguntas SET ImagemUrl = '/img/911.jpeg' WHERE PerguntasId = 5");
            migrationBuilder.Sql("UPDATE perguntas SET ImagemUrl = '/img/Bandiera della Repubblica italiana _ Vettore Premium.jpeg' WHERE PerguntasId = 6");
            migrationBuilder.Sql("UPDATE perguntas SET ImagemUrl = '/img/baixados (2).jpeg' WHERE PerguntasId = 7");
            migrationBuilder.Sql("UPDATE perguntas SET ImagemUrl = '/img/Ventoinha do radiador não funciona_ Saiba o que fazer.jpeg' WHERE PerguntasId = 8");
            migrationBuilder.Sql("UPDATE perguntas SET ImagemUrl = '/img/@branddiee __ Precision Turbo.jpeg' WHERE PerguntasId = 9");
            migrationBuilder.Sql("UPDATE perguntas SET ImagemUrl = '/img/baixados (3).jpeg' WHERE PerguntasId = 10");


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE perguntas SET ImagemUrl = NULL WHERE Id = 1");
            migrationBuilder.Sql("UPDATE perguntas SET ImagemUrl = NULL WHERE Id = 2");
            migrationBuilder.Sql("UPDATE perguntas SET ImagemUrl = NULL WHERE Id = 3");
            migrationBuilder.Sql("UPDATE perguntas SET ImagemUrl = NULL WHERE Id = 4");
            migrationBuilder.Sql("UPDATE perguntas SET ImagemUrl = NULL WHERE Id = 5");
            migrationBuilder.Sql("UPDATE perguntas SET ImagemUrl = NULL WHERE Id = 6");
            migrationBuilder.Sql("UPDATE perguntas SET ImagemUrl = NULL WHERE Id = 7");
            migrationBuilder.Sql("UPDATE perguntas SET ImagemUrl = NULL WHERE Id = 8");
            migrationBuilder.Sql("UPDATE perguntas SET ImagemUrl = NULL WHERE Id = 9");
            migrationBuilder.Sql("UPDATE perguntas SET ImagemUrl = NULL WHERE Id = 10");
        }
    }
}
