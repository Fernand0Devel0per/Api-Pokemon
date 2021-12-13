using System.ComponentModel.DataAnnotations;

namespace PokemonWorld.Data.DTO
{
    public class CreateAtributoDto
    {
        [Required]
        public int Ataque { get; set; }
        [Required]
        public int Defesa { get; set; }
        [Required]
        public int EspecialAtaque { get; set; }
        [Required]
        public int EspecialDefesa { get; set; }
        [Required]
        public int Vida { get; set; }
        [Required]
        public int Velocidade { get; set; }

        
    }
}
