using PokiConsumer.Domain.Models.Utilities;

namespace PokiConsumer.Domain.Models.Movements;

public class MoveAilment : BaseMove
{
    public IList<Resource> Moves { get; set; }
    public IList<Name> Names { get; set; }

    public override string Endpoint => "move-ailment";
}