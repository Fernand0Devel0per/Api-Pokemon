using PokemonWorld.Data.DTO.Pokemon;
using PokemonWorld.Models;
using AutoMapper;

namespace PokemonWorld.Profiles
{
    public class PokemonProfile : Profile
    {
        public PokemonProfile()
        {
            CreateMap<CreatePokemonDTO, Pokemon>();
            CreateMap<Pokemon, ReadPokemonDTO>();
            CreateMap<AtualizarPokemonDTO, Pokemon>();
        }
    }
}
