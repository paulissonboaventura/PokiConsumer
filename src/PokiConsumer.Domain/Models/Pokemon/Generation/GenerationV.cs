using System.Text.Json.Serialization;

namespace PokiConsumer.Domain.Models.Pokemon.Generation;

public class GenerationV
{
    [JsonPropertyName("black-white")]
    public BlackWhite BlackWhite { get; set; }
}

public partial class BlackWhite : Color
{
    public Color Animated { get; set; }
}