using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PokemonWorld.Models
{
    public class Pokemon
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O Numero é campo obrigatorio")]
        [Range(1,151)]
        public int Numero { get; set; }

        [Required(ErrorMessage = "O Nome é campo obrigatorio")]
        [MinLength(3)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Tipo é campo obrigatorio")]
        [MinLength(3)]
        public string Tipo { get; set; }

        public virtual Atributo Atributo { get; set; }

        [Required]
        public int AtributoId { get; set; }



    }
}
