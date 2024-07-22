using PokiConsumer.Domain.Models.Utilities;

namespace PokiConsumer.Domain.Models.Pokemon;

public class Stat
{
    public int BaseStat { get; set; }
    public int Effort { get; set; }
    public Resource StatResource { get; set; }
}