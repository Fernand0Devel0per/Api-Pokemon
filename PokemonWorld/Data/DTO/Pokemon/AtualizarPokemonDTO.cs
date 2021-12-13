using System.ComponentModel.DataAnnotations;

namespace PokemonWorld.Data.DTO.Pokemon
{
    public class AtualizarPokemonDTO
    {
       
        [Range(1, 151)]
        public int Numero { get; set; }

        [MinLength(3)]
        public string Nome { get; set; }

        [MinLength(3)]
        public string Tipo { get; set; }
    }
}

