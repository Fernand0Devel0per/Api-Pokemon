using AutoMapper;
using FluentResults;
using Microsoft.AspNetCore.Mvc;
using PokemonWorld.Data;
using PokemonWorld.Data.DTO;
using PokemonWorld.Models;
using PokemonWorld.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonWorld.Controllers
{   
    [ApiController]
    [Route("[controller]")]
    public class PokemonController : ControllerBase
    {
        private PokemonService _pokemonService;
        private AtributoService _atributoService;

        public PokemonController(PokemonService pokemonService, AtributoService atributoService)
        {
            _pokemonService = pokemonService;
            _atributoService = atributoService;
        }

        [HttpPost]
        public IActionResult CadastrarPokemon([FromBody] PokemonComAtributos dto)
        {
            ReadAtributoDto readAtributo = _atributoService.CadastrarAtributo(dto.Atributo);
            if (readAtributo == null)
            {
                return StatusCode(500);
            }
            ReadPokemonDTO ReadPokemon = _pokemonService.CadastrarPokemon(dto.Pokemon, readAtributo.Id);
            return CreatedAtAction(nameof(RecuperaPokemonPorId), new {Id = ReadPokemon.Id }, ReadPokemon);
            
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaPokemonPorId(int id) 
        {
            ReadPokemonDTO readDto = _pokemonService.RecuperaPokemonPorId(id);
            if (readDto != null)
                return Ok(readDto);

            return NotFound();
        }

        [HttpGet]
        public IActionResult RecuperarTodosPokemons()
        {
            List<ReadPokemonDTO> listaPokemons = _pokemonService.RecuperarTodosPokemons(); 
            return Ok(listaPokemons);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarPokemon(int id, [FromBody]AtualizarPokemonDTO newPokemonDto)
        {
            Result result = _pokemonService.AtualizarPokemon(id, newPokemonDto);
            if (result.IsFailed)
                return NotFound();

            return NoContent();
        }

        [HttpPut("atualizar/todos")]
        public IActionResult AtualizarTodosAtributosPokemon([FromQuery] int id ,[FromBody] CreateAtributoDto dto)
        {
            int atributoId = _pokemonService.RecuperaAtributoId(id);
            if(atributoId != -1)
            {
                Result result = _atributoService.AtualizarTodosAtributos(dto, atributoId);
                if (result.IsFailed)
                {
                    return NotFound();
                }
                return NoContent();
            }
            return NotFound();
        }

        [HttpPut("atualizar/individual")]
        public IActionResult AtualizarAtributoIndidual([FromQuery] int id, string atributo, int value)
        {
            int atributoId = _pokemonService.RecuperaAtributoId(id);
            if (atributoId != -1)
            {
                Result result = _atributoService.AtualizarAtributoIndividual(atributoId, atributo, value);
                if (result.IsFailed)
                {
                    return NotFound();
                }
                return NoContent();
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarPokemon(int id) 
        {
            Pokemon pokemon = _pokemonService.DeletarPokemon(id);
            if (pokemon == null)
            {
                return NotFound();
            }
            _atributoService.DeletarAtributo(pokemon);
            return NoContent();
        }

    }
}
