using System.Text.Json.Serialization;

namespace PokiConsumer.Domain.Models.Pokemon.Generation;

public class GenerationVII
{
    public Color Icons { get; set; }
    [JsonPropertyName("ultra-sun-ultra-moon")]
    public Color UltraSunUltraMoon { get; set; }
}