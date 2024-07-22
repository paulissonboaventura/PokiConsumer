using PokiConsumer.Domain.Models;

namespace PokiConsumer.Domain.Interfaces.Repositories;

public interface IBaseRepository
{
    Task<T> GetByNameAsync<T>(string name) where T : BaseModel, new();
    Task<T> GetByIdAsync<T>(int id) where T : BaseModel, new();
}