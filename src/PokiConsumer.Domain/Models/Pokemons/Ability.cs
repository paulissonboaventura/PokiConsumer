using PokiConsumer.Domain.Models.Utilities;
using System.Text.Json.Serialization;

namespace PokiConsumer.Domain.Models.Pokemon;

public class Ability
{
    [JsonPropertyName("ability")]
    public Resource AbilityResource { get; set; }
    public bool IsHidden { get; set; }
    public int Slot { get; set; }
}