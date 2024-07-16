using PokiConsumer.Domain.Utilities;

namespace PokiConsumer.Domain.Models.Pokemon;

public class Movement
{
    public Resource Move { get; set; }
    public IList<VersionGroupDetail> VersionGroupDetails { get; set; }
}