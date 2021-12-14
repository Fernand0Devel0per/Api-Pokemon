using PokemonWorld.Models;
using System.Collections.Generic;


namespace PokemonWorld.Data.DTO
{
    public class ReadTreinadorDto
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Sexo { get; set; }

        public string Cidade { get; set; }

        public Time Time { get; set; }

    }
}
