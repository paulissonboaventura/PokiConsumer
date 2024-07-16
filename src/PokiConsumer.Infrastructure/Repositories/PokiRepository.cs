using PokiConsumer.Domain.Interfaces.Repositories;
using PokiConsumer.Domain.Models.Pokemon;
using System.Net.Http.Json;
using System.Text.Json;

namespace PokiConsumer.Infrastructure.Repositories;

public class PokiRepository(IHttpClientFactory client, JsonSerializerOptions serializerOptions) : IPokiRepository
{
    private readonly HttpClient _client = client.CreateClient("poki");

    public async Task<Pokemon> Get(string name)
    {
        var response = await _client.GetFromJsonAsync<Pokemon>($"v2/pokemon/{name}", serializerOptions);

        return response;
    }
}