using PokemonWorld.Data.DTO.Pokemon;
using System.ComponentModel.DataAnnotations;

namespace PokemonWorld.Data.DTO
{
    public class PokemonComAtributos
    {
        public CreatePokemonDTO Pokemon { get; set; }

        public CreateAtributoDto Atributo { get; set; }
    }
}
