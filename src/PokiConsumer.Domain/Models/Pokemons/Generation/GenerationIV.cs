using System.Text.Json.Serialization;

namespace PokiConsumer.Domain.Models.Pokemons.Generation;

public class GenerationIV
{
    [JsonPropertyName("diamond-pearl")]
    public Color DiamondPearl { get; set; }
    [JsonPropertyName("heartgold-soulsilver")]
    public Color HeartgoldSoulsilver { get; set; }
    public Color Platinum { get; set; }
}