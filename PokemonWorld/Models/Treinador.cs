using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PokemonWorld.Models
{
    public class Treinador
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [StringLength(1)]
        public string Sexo { get; set; }

        [Required]
        public string Cidade { get; set; }

        public int TimeId { get; set; }

        public virtual Time Time { get; set; }
    }
}
