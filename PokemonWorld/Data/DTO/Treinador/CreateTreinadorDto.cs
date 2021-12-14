using System.ComponentModel.DataAnnotations;

namespace PokemonWorld.Data.DTO
{
    public class CreateTreinadorDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [StringLength(1)]
        public string Sexo { get; set; }

        [Required]
        public string Cidade { get; set; }
    }
}
