using AutoMapper;
using FluentResults;
using PokemonWorld.Data;
using PokemonWorld.Data.DTO;
using PokemonWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonWorld.Services
{
    public class PokemonService
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public PokemonService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            
        }

        public ReadPokemonDTO CadastrarPokemon(CreatePokemonDTO dto, int idAtributo)
        {
            Pokemon pokemon = _mapper.Map<Pokemon>(dto);
            pokemon.AtributoId = idAtributo;
            _context.Pokemons.Add(pokemon);
            _context.SaveChanges();
            return _mapper.Map<ReadPokemonDTO>(pokemon);
        }

        public ReadPokemonDTO RecuperaPokemonPorId(int id)
        {

            Pokemon pokemon = _context.Pokemons.FirstOrDefault(pokemon => pokemon.Id == id);
            if (pokemon != null)
            {
                return _mapper.Map<ReadPokemonDTO>(pokemon);
            }
            return null;
        }

        public List<ReadPokemonDTO> RecuperarTodosPokemons()
        {
            List<Pokemon> pokemons = _context.Pokemons.ToList();
            return _mapper.Map<List<ReadPokemonDTO>>(pokemons);

        }

        public Result AtualizarPokemon(int id, AtualizarPokemonDTO newPokemonDto)
        {
            Pokemon pokemon = _context.Pokemons.FirstOrDefault(pokemon => pokemon.Id == id);
            if (pokemon == null)
                return Result.Fail($"Nenhum pokemon encontrado para este id:{id}");
            
            _mapper.Map(newPokemonDto, pokemon);
            _context.SaveChanges();
            return Result.Ok();
        }

        public Pokemon DeletarPokemon(int id)
        {
            Pokemon pokemon = _context.Pokemons.SingleOrDefault(pokemon => pokemon.Id == id);

            if (pokemon == null)
                return null;

            _context.Remove(pokemon);   
            _context.SaveChanges();
            

            return pokemon;
        }

        public int RecuperaAtributoId(int id)
        {
            Pokemon pokemon = _context.Pokemons.SingleOrDefault(pokemon => pokemon.Id == id);
            if (pokemon != null)
            {
                return pokemon.AtributoId;
            }
            return -1;
        }
    }
}
