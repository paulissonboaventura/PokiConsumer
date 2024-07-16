using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PokiConsumer.Domain;
using PokiConsumer.Domain.Interfaces.Repositories;
using PokiConsumer.Domain.Models.Pokemon.Generation;
using PokiConsumer.Infrastructure.Repositories;
using System.Text.Json;

namespace PokiConsumer.Infrastructure.IoC;

public static class RepositoryContainer
{
    public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddHttpClient("poki", client => client.BaseAddress = new Uri(configuration.GetValue<string>("PokiApi")));

        services.AddTransient<JsonSerializerOptions>(serializerOption => new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower
        });
        services.AddTransient<IPokiRepository, PokiRepository>();

        return services;
    }
}