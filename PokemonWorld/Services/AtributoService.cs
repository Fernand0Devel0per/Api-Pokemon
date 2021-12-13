using AutoMapper;
using FluentResults;
using PokemonWorld.Data;
using PokemonWorld.Data.DTO;
using PokemonWorld.Models;
using System;
using System.Linq;

namespace PokemonWorld.Services
{
    public class AtributoService
    {
        private IMapper _mapper;
        private AppDbContext _context;

        public AtributoService(IMapper mapper, AppDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public ReadAtributoDto CadastrarAtributo(CreateAtributoDto createDto)
        {
            Atributo atributo = _mapper.Map<Atributo>(createDto);
            if (atributo != null)
            {
                _context.Atributos.Add(atributo);
                _context.SaveChanges();
                return _mapper.Map<ReadAtributoDto>(atributo);
            }
            return null;
        }

        public void DeletarAtributo(Pokemon pokemon)
        {
            Atributo atributo = _context.Atributos.SingleOrDefault(atributo => atributo.Id == pokemon.AtributoId);
            if (atributo != null)
            {
                _context.Remove(atributo);
                _context.SaveChanges();
            }
        }

        public Result AtualizarTodosAtributos(CreateAtributoDto dto, int id)
        {
            Atributo atributo = _context.Atributos.FirstOrDefault(atributo => atributo.Id == id);
            if (atributo!= null)
            {
                _mapper.Map(dto, atributo);
                _context.SaveChanges();
                return Result.Ok();
            }
            return Result.Fail("Atributo não encontrado");
        }
    }
}
