using Microsoft.EntityFrameworkCore.Migrations;
using System;

#nullable disable

namespace QuizCarros.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarImagemPerguntas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           migrationBuilder.AddColumn<string>(
           name: "ImagemUrl",
           table: "perguntas",
           nullable: true);
            migrationBuilder.Sql("UPDATE perguntas SET ImagemUrl = '/img/baixados.jpeg'");
            migrationBuilder.Sql("UPDATE perguntas SET ImagemUrl = '/img/Branding Fun_ Ferrari http___marketingisnotselling_com_branding-fun-ferrari_.jpeg'");
            migrationBuilder.Sql("UPDATE perguntas SET ImagemUrl = '/img/baixados (1).jpeg'");
            migrationBuilder.Sql("UPDATE perguntas SET ImagemUrl = '/img/Classic Ford Mustang in the Wild.jpeg'");
            migrationBuilder.Sql("UPDATE perguntas SET ImagemUrl = '/img/911.jpeg'");
            migrationBuilder.Sql("UPDATE perguntas SET ImagemUrl = '/img/Bandiera della Repubblica italiana _ Vettore Premium.jpeg'");
            migrationBuilder.Sql("UPDATE perguntas SET ImagemUrl = '/img/baixados (2).jpeg'");
            migrationBuilder.Sql("UPDATE perguntas SET ImagemUrl = '/img/Ventoinha do radiador não funciona_ Saiba o que fazer.jpeg'");
            migrationBuilder.Sql("UPDATE perguntas SET ImagemUrl = '/img/@branddiee __ Precision Turbo.jpeg'");
            migrationBuilder.Sql("UPDATE perguntas SET ImagemUrl = '/img/baixados (3).jpeg'");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
            name: "ImagemUrl",
            table: "perguntas");
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