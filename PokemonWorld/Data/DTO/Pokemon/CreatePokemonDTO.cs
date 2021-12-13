using System.ComponentModel.DataAnnotations;

namespace PokemonWorld.Data.DTO.Pokemon
{
    public class CreatePokemonDTO
    {
        [Required(ErrorMessage = "O Numero é campo obrigatorio")]
        [Range(1, 151)]
        public int Numero { get; set; }

        [Required(ErrorMessage = "O Nome é campo obrigatorio")]
        [MinLength(3)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Tipo é campo obrigatorio")]
        [MinLength(3)]
        public string Tipo { get; set; }

    }
}
