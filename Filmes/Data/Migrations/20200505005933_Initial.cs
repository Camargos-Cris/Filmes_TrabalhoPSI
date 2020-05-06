using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Filmes.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Filmes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(nullable: true),
                    Data_lancamento = table.Column<DateTime>(nullable: false),
                    Genero = table.Column<string>(nullable: true),
                    Avaliacao = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Autor = table.Column<string>(nullable: true),
                    Classificacao = table.Column<string>(nullable: true),
                    Descrição = table.Column<string>(nullable: true),
                    Num_votos = table.Column<decimal>(nullable: false),
                    Nota = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Series",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(nullable: true),
                    Data_lancamento = table.Column<DateTime>(nullable: false),
                    Quantidade_temp = table.Column<int>(nullable: false),
                    Genero = table.Column<string>(nullable: true),
                    Avaliacao = table.Column<decimal>(nullable: false),
                    Autor = table.Column<string>(nullable: true),
                    Classificacao = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    Num_votos = table.Column<decimal>(nullable: false),
                    Nota = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Series", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Filmes");

            migrationBuilder.DropTable(
                name: "Series");
        }
    }
}
