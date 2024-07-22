namespace PokiConsumer.Domain.Models.Pokemon;

public class Cry(string latest, string legacy)
{
    public string Latest { get; set; } = latest;
    public string Legacy { get; set; } = legacy;
}