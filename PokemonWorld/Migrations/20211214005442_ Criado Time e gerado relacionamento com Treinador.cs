using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace PokemonWorld.Migrations
{
    public partial class CriadoTimeegeradorelacionamentocomTreinador : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pokemons_Treinadores_TreinadorId",
                table: "Pokemons");

            migrationBuilder.DropIndex(
                name: "IX_Pokemons_TreinadorId",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "TreinadorId",
                table: "Pokemons");

            migrationBuilder.AddColumn<int>(
                name: "TimeId",
                table: "Treinadores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Times",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Pokemon_1 = table.Column<int>(type: "int", nullable: false),
                    Pokemon_2 = table.Column<int>(type: "int", nullable: false),
                    Pokemon_3 = table.Column<int>(type: "int", nullable: false),
                    Pokemon_4 = table.Column<int>(type: "int", nullable: false),
                    Pokemon_5 = table.Column<int>(type: "int", nullable: false),
                    Pokemon_6 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Times", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Treinadores_TimeId",
                table: "Treinadores",
                column: "TimeId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Treinadores_Times_TimeId",
                table: "Treinadores",
                column: "TimeId",
                principalTable: "Times",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Treinadores_Times_TimeId",
                table: "Treinadores");

            migrationBuilder.DropTable(
                name: "Times");

            migrationBuilder.DropIndex(
                name: "IX_Treinadores_TimeId",
                table: "Treinadores");

            migrationBuilder.DropColumn(
                name: "TimeId",
                table: "Treinadores");

            migrationBuilder.AddColumn<int>(
                name: "TreinadorId",
                table: "Pokemons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_TreinadorId",
                table: "Pokemons",
                column: "TreinadorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemons_Treinadores_TreinadorId",
                table: "Pokemons",
                column: "TreinadorId",
                principalTable: "Treinadores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
