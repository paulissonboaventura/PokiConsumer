using PokiConsumer.Domain.Models.Pokemon;

namespace PokiConsumer.Domain.Interfaces.Repositories;

public interface IPokiRepository
{
    Task<Pokemon> Get(string name);
}