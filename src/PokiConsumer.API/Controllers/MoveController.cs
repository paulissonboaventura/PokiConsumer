using Microsoft.AspNetCore.Mvc;
using PokiConsumer.Domain.Interfaces.Repositories;
using PokiConsumer.Domain.Models.Movements;
using PokiConsumer.Domain.Models.Pokemon;

namespace PokiConsumer.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MoveController(IBaseRepository _repository) : ControllerBase
    {
        [HttpGet("GetMoveTargetById/{id}")]
        public async Task<ActionResult<MoveTarget>> GetMoveTargetById(int id)
        {
            var response = await _repository.GetByIdAsync<MoveTarget>(id);

            return Ok(response);
        }

        [HttpGet("GetMoveTargetByName/{name}")]
        public async Task<ActionResult<MoveTarget>> GetMoveTargetByName(string name)
        {
            var response = await _repository.GetByNameAsync<MoveTarget>(name);

            return Ok(response);
        }

        [HttpGet("GetMoveDamageClassById/{id}")]
        public async Task<ActionResult<MoveDamageClass>> GetMoveDamageClassById(int id)
        {
            var response = await _repository.GetByIdAsync<MoveDamageClass>(id);

            return Ok(response);
        }

        [HttpGet("GetMoveDamageClassByName/{name}")]
        public async Task<ActionResult<MoveDamageClass>> GetMoveDamageClassByName(string name)
        {
            var response = await _repository.GetByNameAsync<MoveDamageClass>(name);

            return Ok(response);
        }

        [HttpGet("GetMoveLearnMethodById/{id}")]
        public async Task<ActionResult<MoveLearnMethod>> GetMoveLearnMethodById(int id)
        {
            var response = await _repository.GetByIdAsync<MoveLearnMethod>(id);

            return Ok(response);
        }

        [HttpGet("GetMoveLearnMethodByName/{name}")]
        public async Task<ActionResult<MoveLearnMethod>> GetMoveLearnMethodByName(string name)
        {
            var response = await _repository.GetByNameAsync<MoveLearnMethod>(name);

            return Ok(response);
        }

        [HttpGet("GetMoveCategoryById/{id}")]
        public async Task<ActionResult<MoveCategory>> GetMoveCategoryById(int id)
        {
            var response = await _repository.GetByIdAsync<MoveCategory>(id);

            return Ok(response);
        }

        [HttpGet("GetMoveCategoryByName/{name}")]
        public async Task<ActionResult<MoveCategory>> GetMoveCategoryByName(string name)
        {
            var response = await _repository.GetByNameAsync<MoveCategory>(name);

            return Ok(response);
        }

        [HttpGet("GetMoveBattleStyleById/{id}")]
        public async Task<ActionResult<MoveBattleStyle>> GetMoveBattleStyleById(int id)
        {
            var response = await _repository.GetByIdAsync<MoveBattleStyle>(id);

            return Ok(response);
        }

        [HttpGet("GetMoveBattleStyleByName/{name}")]
        public async Task<ActionResult<MoveBattleStyle>> GetMoveBattleStyleByName(string name)
        {
            var response = await _repository.GetByNameAsync<MoveBattleStyle>(name);

            return Ok(response);
        }

        [HttpGet("GetMoveAilmentById/{id}")]
        public async Task<ActionResult<MoveAilment>> GetMoveAilmentById(int id)
        {
            var response = await _repository.GetByIdAsync<MoveAilment>(id);

            return Ok(response);
        }

        [HttpGet("GetMoveAilmentByName/{name}")]
        public async Task<ActionResult<MoveAilment>> GetMoveAilmentByName(string name)
        {
            var response = await _repository.GetByNameAsync<MoveAilment>(name);

            return Ok(response);
        }
    }
}