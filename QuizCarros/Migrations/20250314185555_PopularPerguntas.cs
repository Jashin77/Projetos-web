using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizCarros.Migrations
{
    /// <inheritdoc />
    public partial class PopularPerguntas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO perguntas(Enunciado,Alternativa1,Alternativa2,Alternativa3,Alternativa4,RespostaCorreta)" +
                "VALUES('Qual foi o primeiro carro produzido em massa?','Ford Model T','Chevrolet Bel Air','Volkswagen Fusca','Fiat Uno',0)");

            migrationBuilder.Sql("INSERT INTO perguntas(Enunciado,Alternativa1,Alternativa2,Alternativa3,Alternativa4,RespostaCorreta)" +
                "VALUES('De qual país é a origem da marca Ferrari?','Alemanha','Itália','França','Reino Unido',1)");

            migrationBuilder.Sql("INSERT INTO perguntas(Enunciado,Alternativa1,Alternativa2,Alternativa3,Alternativa4,RespostaCorreta)" +
                "VALUES('Quantos campeonatos de Formula 1 o piloto Ayrton Senna conquistou?','1','2','3','4',2)");

            migrationBuilder.Sql("INSERT INTO perguntas(Enunciado,Alternativa1,Alternativa2,Alternativa3,Alternativa4,RespostaCorreta)" +
               "VALUES('Qual fabricante é responsável pelo icônico modelo Mustang?','Chevrolet','Dodge','Ford','Toyota',2)");

            migrationBuilder.Sql("INSERT INTO perguntas(Enunciado,Alternativa1,Alternativa2,Alternativa3,Alternativa4,RespostaCorreta)" +
               "VALUES('Qual desses modelos é considerado o carro símbulo da Porsche?','Porsche 911','Porsche Macan','Porsche Boxter','Porsche Panamera',0)");

            migrationBuilder.Sql("INSERT INTO perguntas(Enunciado,Alternativa1,Alternativa2,Alternativa3,Alternativa4,RespostaCorreta)" +
               "VALUES('Qual desses modelos é um ícone dos carros esportivos italianos?','Ferrari F40','Ford Mustang','Chevrolet Camaro','Nissan GT-R',0)");

            migrationBuilder.Sql("INSERT INTO perguntas(Enunciado,Alternativa1,Alternativa2,Alternativa3,Alternativa4,RespostaCorreta)" +
               "VALUES('Em que ano foi fundada a Porsche?','1931','1948','1920','1955',0)");

            migrationBuilder.Sql("INSERT INTO perguntas(Enunciado,Alternativa1,Alternativa2,Alternativa3,Alternativa4,RespostaCorreta)" +
               "VALUES('Qual a principal função de um radiador em um automóvel?','Armazenar combustivel','Resfriar o motor','Aumentar a potência','Lubrificar as peças do motor',1)");

            migrationBuilder.Sql("INSERT INTO perguntas(Enunciado,Alternativa1,Alternativa2,Alternativa3,Alternativa4,RespostaCorreta)" +
               "VALUES('Qual a função de um turbo compressor em um automovél?','Resfriar o motor','Aumentar a potência,colocando mair ar dentro do motor','Reduzir o consumo de combustível','Controlar a ignição',1)");

            migrationBuilder.Sql("INSERT INTO perguntas(Enunciado,Alternativa1,Alternativa2,Alternativa3,Alternativa4,RespostaCorreta)" +
               "VALUES('Qual corrida tradicional do automobilismo é conhecida pela sua longa duração?','24 horas de Le Mans','grande prêmio de mônaco','indianapolis 500','500 milhas de Daytona',0)");


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM perguntas");
        }
    }
}
