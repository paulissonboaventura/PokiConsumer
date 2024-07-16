namespace PokiConsumer.Domain.Models.Pokemon;
public abstract class BaseSprite(string frontDefault)
{
    public string FrontDefault { get; set; } = frontDefault;
}