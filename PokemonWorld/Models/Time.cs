using System.ComponentModel.DataAnnotations;

namespace PokemonWorld.Models
{
    public class Time
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public virtual Treinador Treinador { get; set; }

        public int Pokemon_1 { get; set; }

        public int Pokemon_2 { get; set; }

        public int Pokemon_3 { get; set; }

        public int Pokemon_4 { get; set; }

        public int Pokemon_5 { get; set; }

        public int Pokemon_6 { get; set; }


    }
}
