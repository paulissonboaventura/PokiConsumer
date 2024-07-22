using System.Text.Json.Serialization;

namespace PokiConsumer.Domain.Models.Utilities;

public class FlavorText
{
    [JsonPropertyName("flavor_text")]
    public string Name { get; set; }
    public Resource Language { get; set; }
    public Resource Version { get; set; }
}