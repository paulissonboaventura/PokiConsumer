namespace PokiConsumer.Domain.Models.Utilities;

public class Encounter
{
    public int MinLevel { get; set; }
    public int MaxLevel { get; set; }
    public int Chance { get; set; }
    public Resource Method { get; set; }
    public IList<Resource> ConditionValues { get; set; }
}