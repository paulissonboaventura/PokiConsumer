using PokiConsumer.Domain.Models.Utilities;

namespace PokiConsumer.Domain.Models.Movements;

public class MoveTarget : BaseMove
{
    public IList<Description> Descriptions { get; set; }
    public IList<Resource> Moves { get; set; }
    public IList<Name> Names { get; set; }

    public override string Endpoint => "move-target";
}

public class MoveDamageClass : MoveTarget
{
    public override string Endpoint => "move-damage-class";
}