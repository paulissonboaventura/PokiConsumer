namespace PokiConsumer.Domain.Models.Pokemon;

public class Home(string frontDefault, string frontFemale, string frontShiny, string frontShinyFemale) : BaseSprite(frontDefault)
{
    public string FrontFemale { get; set; } = frontFemale;
    public string FrontShiny { get; set; } = frontShiny;
    public string FrontShinyFemale { get; set; } = frontShinyFemale;
}