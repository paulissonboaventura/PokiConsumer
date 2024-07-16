using System.Text.Json.Serialization;
using PokiConsumer.Domain.Utilities;

namespace PokiConsumer.Domain.Models.Pokemon;

public class Held
{
    public Resource Item { get; set; }
    [JsonPropertyName("version_details")]
    public IList<VersionDetail> VersionDetails { get; set; }
}