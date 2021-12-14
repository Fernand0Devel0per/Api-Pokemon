using AutoMapper;
using PokemonWorld.Data.DTO;
using PokemonWorld.Models;

namespace PokemonWorld.Profiles
{
    public class TreinadorProfile : Profile
    {

        public TreinadorProfile()
        {
            CreateMap<CreateTreinadorDto, Treinador>();
            CreateMap<Treinador, ReadTreinadorDto>();
            CreateMap<AtualizaTreinadorDto, Treinador>();
        }
    }
}
