using System.Text.Json.Serialization;

namespace PokiConsumer.Domain.Models.Utilities;

public class Name
{
    [JsonPropertyName("name")]
    public string PropertyName { get; set; }
    public Resource Language { get; set; }
}