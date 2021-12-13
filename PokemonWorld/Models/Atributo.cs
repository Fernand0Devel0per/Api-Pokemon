using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PokemonWorld.Models
{
    public class Atributo
    {
        [Key]
        [Required]
        public int Id { get; set; }

        public int Ataque { get; set; }
        public int Defesa { get; set; }
        public int EspecialAtaque { get; set; }
        public int EspecialDefesa { get; set; }
        public int Vida { get; set; }
        public int Velocidade { get; set; }
        [JsonIgnore]
        public virtual Pokemon Pokemon { get; set; }



    }
}
