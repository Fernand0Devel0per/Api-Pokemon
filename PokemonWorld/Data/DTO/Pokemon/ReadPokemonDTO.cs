using PokemonWorld.Models;
using System.ComponentModel.DataAnnotations;

namespace PokemonWorld.Data.DTO
{
    public class ReadPokemonDTO
    {
        
        public int Id { get; set; }
        
        public int Numero { get; set; }

        public string Nome { get; set; }

        public string Tipo { get; set; }

        public Atributo Atributo { get; set; }     
    }
}
