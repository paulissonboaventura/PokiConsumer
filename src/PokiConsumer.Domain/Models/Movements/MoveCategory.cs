using PokiConsumer.Domain.Models.Utilities;

namespace PokiConsumer.Domain.Models.Movements;

public class MoveCategory : BaseMove
{
    public IList<Description> Descriptions { get; set; }
    public IList<Resource> Moves { get; set; }

    public override string Endpoint => "move-category";
}