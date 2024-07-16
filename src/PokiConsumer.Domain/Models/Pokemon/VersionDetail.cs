using PokiConsumer.Domain.Utilities;

namespace PokiConsumer.Domain.Models.Pokemon;

public class VersionDetail
{
    public VersionDetail(int rarity, Resource version)
    {
        Rarity = rarity;
        Version = version;
    }

    public int Rarity { get; set; }
    public required Resource Version { get; set; }
}