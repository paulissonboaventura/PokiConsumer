using System.Text.Json.Serialization;

namespace PokiConsumer.Domain.Models.Pokemon.Generation;

public class GenerationI
{
    [JsonPropertyName("red-blue")]
    public Color RedBlue { get; set; }
    public Color Yellow { get; set; }
}