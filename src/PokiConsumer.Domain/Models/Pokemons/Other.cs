namespace PokiConsumer.Domain.Models.Pokemon;

public class Other(DreamWorld dreamWorld, Home home, OfficialArtwork officialArtwork, Showdown showdown)
{
    public DreamWorld DreamWorld { get; set; } = dreamWorld;
    public Home Home { get; set; } = home;
    public OfficialArtwork OfficialArtwork { get; set; } = officialArtwork;
    public Showdown Showdown { get; set; } = showdown;
}