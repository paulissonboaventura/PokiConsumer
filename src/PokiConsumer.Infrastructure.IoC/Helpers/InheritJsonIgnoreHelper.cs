using System.Reflection;
using System.Text.Json.Serialization.Metadata;
using System.Text.Json.Serialization;

namespace PokiConsumer.Infrastructure.IoC.Helpers;
public static class InheritJsonIgnoreHelper
{
    public static void InheritJsonIgnore(JsonTypeInfo jsonTypeInfo)
    {
        if (jsonTypeInfo.Kind is not JsonTypeInfoKind.Object)
            return;

        for (int i = 0; i < jsonTypeInfo.Properties.Count; i++)
        {
            if (jsonTypeInfo.Properties[i].AttributeProvider is not PropertyInfo propertyInfo)
                continue;

            if (propertyInfo.GetCustomAttribute<JsonIgnoreAttribute>() is null)
                continue;

            jsonTypeInfo.Properties.RemoveAt(i--);
        }
    }
}