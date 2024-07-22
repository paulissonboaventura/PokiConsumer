namespace PokiConsumer.Domain.Models.Utilities;

public class VersionEncounterDetail : BaseVersion
{
    public int Chance { get; set; }
    public IList<Encounter> EncounterDetails { get; set; }
}