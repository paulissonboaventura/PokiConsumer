using Microsoft.AspNetCore.Mvc;
using PokiConsumer.Domain.Interfaces.Repositories;
using PokiConsumer.Domain.Models.Pokemon;

namespace PokiConsumer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokiController(IPokiRepository _repository) : ControllerBase
    {
        [HttpGet("GetPokemon/{name}")]
        public async Task<ActionResult<Pokemon>> GetPokemon(string name)
        {
            var content = await _repository.Get(name);

            return Ok(content);
        }
    }
}