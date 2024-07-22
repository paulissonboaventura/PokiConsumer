using System.Text.Json.Serialization;

namespace PokiConsumer.Domain.Models.Pokemons.Generation;

public class GenerationI
{
    [JsonPropertyName("red-blue")]
    public Color RedBlue { get; set; }
    public Color Yellow { get; set; }
}