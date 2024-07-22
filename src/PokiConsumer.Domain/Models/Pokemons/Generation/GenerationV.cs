using System.Text.Json.Serialization;

namespace PokiConsumer.Domain.Models.Pokemons.Generation;

public class GenerationV
{
    [JsonPropertyName("black-white")]
    public BlackWhite BlackWhite { get; set; }
}

public partial class BlackWhite : Color
{
    public Color Animated { get; set; }
}