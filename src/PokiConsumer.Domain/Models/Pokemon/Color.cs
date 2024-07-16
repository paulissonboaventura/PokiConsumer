using System.Text.Json.Serialization;

namespace PokiConsumer.Domain.Models.Pokemon;

public class Color
{
    public string? FrontDefault { get; set; }
    public string? BackDefault { get; set; }
    public string? FrontFemale { get; set; }
    public string? BackFemale { get; set; }
    public string? FrontShiny { get; set; }
    public string? BackShiny { get; set; }
    public string? FrontShinyFemale { get; set; }
    public string? BackShinyFemale { get; set; }
    public string? FrontShinyTransparent { get; set; }
    public string? BackShinyTransparent { get; set; }
    public string? FrontGray { get; set; }
    public string? BackGray { get; set; }
    public string? FrontTransparent { get; set; }
    public string? BackTransparent { get; set; }
}