
using Microsoft.EntityFrameworkCore;
using PokemonWorld.Models;

namespace PokemonWorld.Data
{
    public class AppDbContext : DbContext
    {
     
        

        public AppDbContext(DbContextOptions<AppDbContext> context)
            : base(context)
        {
           
           
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<Atributo>()
                .HasOne(atributo => atributo.Pokemon)
                .WithOne(pokemon => pokemon.Atributo)
                .HasForeignKey<Pokemon>(pokemon => pokemon.AtributoId);

            builder.Entity<Time>()
                .HasOne(time => time.Treinador)
                .WithOne(treinador => treinador.Time)
                .HasForeignKey<Treinador>(treinador => treinador.TimeId);

        }

        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<Atributo> Atributos { get; set; }
        public DbSet<Treinador> Treinadores { get; set; }
        public DbSet<Time> Times { get; set; }
        
    }
}
