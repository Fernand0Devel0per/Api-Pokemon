using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace PokemonWorld.Migrations
{
    public partial class CriadoRealacionamentodeumparamuitosentreTreinadorePokemon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Atributos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Ataque = table.Column<int>(type: "int", nullable: false),
                    Defesa = table.Column<int>(type: "int", nullable: false),
                    EspecialAtaque = table.Column<int>(type: "int", nullable: false),
                    EspecialDefesa = table.Column<int>(type: "int", nullable: false),
                    Vida = table.Column<int>(type: "int", nullable: false),
                    Velocidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atributos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Treinadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Sexo = table.Column<string>(type: "varchar(1)", maxLength: 1, nullable: false),
                    Cidade = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treinadores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pokemons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    Tipo = table.Column<string>(type: "text", nullable: false),
                    AtributoId = table.Column<int>(type: "int", nullable: false),
                    TreinadorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pokemons_Atributos_AtributoId",
                        column: x => x.AtributoId,
                        principalTable: "Atributos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pokemons_Treinadores_TreinadorId",
                        column: x => x.TreinadorId,
                        principalTable: "Treinadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_AtributoId",
                table: "Pokemons",
                column: "AtributoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_TreinadorId",
                table: "Pokemons",
                column: "TreinadorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pokemons");

            migrationBuilder.DropTable(
                name: "Atributos");

            migrationBuilder.DropTable(
                name: "Treinadores");
        }
    }
}
