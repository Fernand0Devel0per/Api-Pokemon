using AutoMapper;
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
        }

        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<Atributo> Atributos { get; set; }
    }
}
