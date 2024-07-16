namespace PokiConsumer.Domain.Models.Pokemon;

public class DreamWorld(string frontDefault, string frontFemale) : BaseSprite(frontDefault)
{
    public string FrontFemale { get; set; } = frontFemale;
}