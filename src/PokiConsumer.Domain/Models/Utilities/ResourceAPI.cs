namespace PokiConsumer.Domain.Models.Utilities;

public abstract class ResourceAPI(string url)
{
    public string Url { get; } = url;
}