using PokiConsumer.Domain.Models.Pokemons.Generation;

namespace PokiConsumer.Domain.Models.Pokemon;

public class Sprite(string frontDefault, string backDefault, string backFemale, string backShiny, string backShinyFemale, string frontFemale, string frontShiny, string frontShinyFemale) : BaseSprite(frontDefault)
{
    public string BackDefault { get; set; } = backDefault;
    public string BackFemale { get; set; } = backFemale;
    public string BackShiny { get; set; } = backShiny;
    public string BackShinyFemale { get; set; } = backShinyFemale;
    public string FrontFemale { get; set; } = frontFemale;
    public string FrontShiny { get; set; } = frontShiny;
    public string FrontShinyFemale { get; set; } = frontShinyFemale;
    public Other Other { get; set; }
    public GenerationVersion Versions { get; set; }
}