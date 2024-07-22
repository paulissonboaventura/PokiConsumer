namespace PokiConsumer.Domain.Models.Movements;

public abstract class BaseMove : BaseModel
{
    public int Id { get; set; }
    public string Name { get; set; }
}