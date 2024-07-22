using PokiConsumer.Domain.Interfaces.Repositories;
using PokiConsumer.Domain.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace PokiConsumer.Infrastructure.Repositories;
public class BaseRepository(IHttpClientFactory httpClientFactory, JsonSerializerOptions serializerOptions) : IBaseRepository
{
    public readonly HttpClient _client = httpClientFactory.CreateClient("poki");

    public Task<T> GetByIdAsync<T>(int id) where T : BaseModel, new() => GetByParamAsync<T>(id.ToString());
    public Task<T> GetByNameAsync<T>(string name) where T : BaseModel, new() => GetByParamAsync<T>(name);
    private async Task<T> GetByParamAsync<T>(string param) where T : BaseModel, new()
    {
        T instance = new();
        var endpoint = instance.Endpoint;
        if (endpoint is null)
            throw new ArgumentNullException();

        return await _client.GetFromJsonAsync<T>($"{endpoint}/{param}", serializerOptions);
    }
}