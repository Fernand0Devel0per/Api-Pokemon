using AutoMapper;
using PokemonWorld.Data.DTO;
using PokemonWorld.Models;

namespace PokemonWorld.Profiles
{
    public class AtributoProfile : Profile
    {
        public AtributoProfile()
        {
            CreateMap<CreateAtributoDto, Atributo>();
            CreateMap<Atributo, ReadAtributoDto>();
            
        }
    }
}
