using AutoMapper;
using PokemonWorld.Data;

namespace PokemonWorld.Services
{
    public class TreinadorService
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public TreinadorService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

    }
}
