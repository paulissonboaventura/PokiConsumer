using PokiConsumer.Domain.Models.Utilities;
using System.Text.Json.Serialization;

namespace PokiConsumer.Domain.Models.Utilities;
public class Description
{
    [JsonPropertyName("description")]
    public string Name { get; set; }
    public Resource Language { get; set; }
}