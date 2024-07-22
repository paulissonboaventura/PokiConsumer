using Microsoft.AspNetCore.Mvc;
using PokiConsumer.Domain.Interfaces.Repositories;
using PokiConsumer.Domain.Models.Movements;
using PokiConsumer.Domain.Models.Pokemon;

namespace PokiConsumer.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PokemonController(IBaseRepository _repository) : ControllerBase
    {
        [HttpGet("GetPokemon/{name}")]
        public async Task<ActionResult<Pokemon>> GetPokemon(string name)
        {
            var content = await _repository.GetByNameAsync<Pokemon>(name);

            return Ok(content);
        }
    }
}