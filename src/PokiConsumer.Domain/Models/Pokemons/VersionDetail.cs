using PokiConsumer.Domain.Models.Utilities;

namespace PokiConsumer.Domain.Models.Pokemon;

public class VersionDetail
{
    public int Rarity { get; set; }
    public required Resource Version { get; set; }
}