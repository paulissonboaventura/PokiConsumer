using System.Text.Json.Serialization;
using PokiConsumer.Domain.Models.Pokemons;
using PokiConsumer.Domain.Models.Utilities;

namespace PokiConsumer.Domain.Models.Pokemon;

public class Pokemon : BaseModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Order { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }
    public int BaseExperience { get; set; }
    public bool IsDefault { get; set; }
    public string LocationAreaEncounters { get; set; }
    [JsonPropertyName("cries")]
    public Cry Cry { get; set; }
    public Resource Species { get; set; }
    [JsonPropertyName("sprites")]
    public Sprite Sprite { get; set; }
    public IList<Ability> Abilities { get; set; }
    public IList<Ability> PastAbilities { get; set; }
    public IList<Type> Types { get; set; }
    public IList<Type> PastTypes { get; set; }
    public IList<Stat> Stats { get; set; }
    public IList<Resource> Forms { get; set; }
    public IList<VersionGameIndex> GameIndices { get; set; }
    public IList<Held> HeldItems { get; set; }
    [JsonPropertyName("moves")]
    public IList<Movement> Movements { get; set; }

    public override string Endpoint => "pokemon";
}