using System.Text.Json.Serialization;

namespace PokiConsumer.Domain.Models.Utilities;

public class Effect
{
    [JsonPropertyName("effect")]
    public string Name { get; set; }
    public Resource Language { get; set; }
}