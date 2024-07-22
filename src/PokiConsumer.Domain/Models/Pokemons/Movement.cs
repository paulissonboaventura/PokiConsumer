using PokiConsumer.Domain.Models.Pokemon;
using PokiConsumer.Domain.Models.Utilities;

namespace PokiConsumer.Domain.Models.Pokemons;

public class Movement
{
    public Resource Move { get; set; }
    public IList<VersionGroupDetail> VersionGroupDetails { get; set; }
}