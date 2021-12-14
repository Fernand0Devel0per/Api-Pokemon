using AutoMapper;
using PokemonWorld.Data.DTO;
using PokemonWorld.Models;

namespace PokemonWorld.Profiles
{
    public class TimeProfile : Profile
    {
        public TimeProfile()
        {
            CreateMap<CreateTimeDto, Time>();
            CreateMap<Time, ReadTimeDto>();
            CreateMap<AtualizarTimeDto, Time>();
        }
    }
}
