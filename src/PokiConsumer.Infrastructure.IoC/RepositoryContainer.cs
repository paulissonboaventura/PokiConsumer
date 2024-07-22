using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using PokiConsumer.Domain.Interfaces.Repositories;
using PokiConsumer.Infrastructure.IoC.Helpers;
using PokiConsumer.Infrastructure.IoC.Options;
using PokiConsumer.Infrastructure.Repositories;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;

namespace PokiConsumer.Infrastructure.IoC;

public static class RepositoryContainer
{
    public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration)
    {
        PokiOptions pokiOptions = new();
        configuration.GetSection(nameof(PokiOptions)).Bind(pokiOptions);

        services.AddHttpClient("poki", client => client.BaseAddress = new Uri($"{pokiOptions.ApiUrl}/{pokiOptions.Version}/"));

        services.AddTransient<IBaseRepository, BaseRepository>();
        services.AddTransient<PokiOptions>(options => pokiOptions);
        services.AddTransient<JsonSerializerOptions>(serializerOption => new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
            TypeInfoResolver = new DefaultJsonTypeInfoResolver
            {
                Modifiers = { InheritJsonIgnoreHelper.InheritJsonIgnore }
            }
        });

        return services;
    }
}