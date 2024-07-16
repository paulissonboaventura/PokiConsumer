namespace PokiConsumer.Domain.Models.Pokemon;

public class OfficialArtwork(string frontDefault, string frontShiny) : BaseSprite(frontDefault)
{
    public string FrontShiny { get; set; } = frontShiny;
}