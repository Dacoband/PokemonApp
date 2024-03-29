﻿
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PokemonReviewApp.Data;
using PokemonReviewApp.Dto;
using PokemonReviewApp.Interface;
using PokemonReviewApp.Models;



namespace PokemonReviewApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : Controller
    {
        private readonly IPokemonRespository _pokemonRespository;
        private readonly IMapper _mapper;
        

        public PokemonController(IPokemonRespository pokemonRespository, IMapper mapper )
        {
            _pokemonRespository = pokemonRespository;
            _mapper = mapper;
            
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Pokemon>))]

        public IActionResult GetPokemons()
        {
            var pokemons =_mapper.Map<List<PokemonDto>>(_pokemonRespository.GetPokemons());


            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(pokemons);
        }

        [HttpGet("{pokeId}")]
        [ProducesResponseType(200, Type = typeof(Pokemon))]
        [ProducesResponseType(400)]
        public IActionResult GetPokemon(int pokeId)
        {
            if (!_pokemonRespository.PokemonExists(pokeId))
                return NotFound();

            var pokemon = _mapper.Map<PokemonDto>(_pokemonRespository.GetPokemon(pokeId));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(pokemon);
        }

        [HttpGet("pokeId/rating")]
        [ProducesResponseType(200, Type = typeof(decimal))]
        [ProducesResponseType(400)] 
        public IActionResult GetPokemonRating(int pokeId)
        {
            if (!_pokemonRespository.PokemonExists(pokeId))
                return NotFound();
            var rating = _pokemonRespository.GetPokemonRating(pokeId);

            if(!ModelState.IsValid)
                return BadRequest();

            return Ok(rating);
        }
    }
}
