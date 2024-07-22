using System.Text.Json.Serialization;

namespace PokiConsumer.Domain.Models.Pokemons.Generation;

public class GenerationVI
{
    [JsonPropertyName("omegaruby-alphasapphire")]
    public Color OmegaRubyAlphaSapphire { get; set; }
    [JsonPropertyName("x-y")]
    public Color XY { get; set; }
}