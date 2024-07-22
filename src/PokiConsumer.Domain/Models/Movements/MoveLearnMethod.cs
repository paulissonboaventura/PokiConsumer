using PokiConsumer.Domain.Models.Utilities;

namespace PokiConsumer.Domain.Models.Movements;

public class MoveLearnMethod : BaseMove
{
    public IList<Description> Descriptions { get; set; }
    public IList<Name> Names { get; set; }
    public override string Endpoint => "move-learn-method";
}