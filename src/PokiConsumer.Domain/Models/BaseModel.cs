using System.Text.Json.Serialization;

namespace PokiConsumer.Domain.Models;
public abstract class BaseModel
{
    [JsonIgnore]
    public abstract string Endpoint { get; }
}