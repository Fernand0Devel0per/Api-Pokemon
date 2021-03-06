// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PokemonWorld.Data;

namespace PokemonWorld.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211213225636_ Criado Realacionamento de um para muitos entre Treinador e Pokemon")]
    partial class CriadoRealacionamentodeumparamuitosentreTreinadorePokemon
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.12");

            modelBuilder.Entity("PokemonWorld.Models.Atributo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Ataque")
                        .HasColumnType("int");

                    b.Property<int>("Defesa")
                        .HasColumnType("int");

                    b.Property<int>("EspecialAtaque")
                        .HasColumnType("int");

                    b.Property<int>("EspecialDefesa")
                        .HasColumnType("int");

                    b.Property<int>("Velocidade")
                        .HasColumnType("int");

                    b.Property<int>("Vida")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Atributos");
                });

            modelBuilder.Entity("PokemonWorld.Models.Pokemon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AtributoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("TreinadorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AtributoId")
                        .IsUnique();

                    b.HasIndex("TreinadorId");

                    b.ToTable("Pokemons");
                });

            modelBuilder.Entity("PokemonWorld.Models.Treinador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("varchar(1)");

                    b.HasKey("Id");

                    b.ToTable("Treinadores");
                });

            modelBuilder.Entity("PokemonWorld.Models.Pokemon", b =>
                {
                    b.HasOne("PokemonWorld.Models.Atributo", "Atributo")
                        .WithOne("Pokemon")
                        .HasForeignKey("PokemonWorld.Models.Pokemon", "AtributoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PokemonWorld.Models.Treinador", "Treinador")
                        .WithMany("Pokemons")
                        .HasForeignKey("TreinadorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Atributo");

                    b.Navigation("Treinador");
                });

            modelBuilder.Entity("PokemonWorld.Models.Atributo", b =>
                {
                    b.Navigation("Pokemon");
                });

            modelBuilder.Entity("PokemonWorld.Models.Treinador", b =>
                {
                    b.Navigation("Pokemons");
                });
#pragma warning restore 612, 618
        }
    }
}
