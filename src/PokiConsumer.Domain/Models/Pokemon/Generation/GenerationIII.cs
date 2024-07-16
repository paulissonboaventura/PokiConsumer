using System.Text.Json.Serialization;

namespace PokiConsumer.Domain.Models.Pokemon.Generation;

public class GenerationIII
{
    public Color Emerald { get; set; }
    [JsonPropertyName("firered-leafgreen")]
    public Color FireredLeafgreen { get; set; }
    [JsonPropertyName("ruby-sapphire")]
    public Color RubySapphire { get; set; }
}