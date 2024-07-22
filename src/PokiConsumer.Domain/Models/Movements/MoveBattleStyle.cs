using PokiConsumer.Domain.Models.Utilities;

namespace PokiConsumer.Domain.Models.Movements;

public class MoveBattleStyle : BaseMove
{
    public IList<Name> Names { get; set; }

    public override string Endpoint => "move-battle-style";
}