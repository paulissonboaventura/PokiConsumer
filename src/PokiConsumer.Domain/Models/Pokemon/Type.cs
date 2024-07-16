using PokiConsumer.Domain.Utilities;
using System.Text.Json.Serialization;

namespace PokiConsumer.Domain.Models.Pokemon;

public class Type
{
    public int Slot { get; set; }
    [JsonPropertyName("type")]
    public Resource TypeResource { get; set; }
}