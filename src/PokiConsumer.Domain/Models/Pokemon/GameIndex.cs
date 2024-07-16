using System.Text.Json.Serialization;
using PokiConsumer.Domain.Utilities;

namespace PokiConsumer.Domain.Models.Pokemon;

public class GameIndex
{
    public int Index { get; set; }
    public Resource Version { get; set; }
}