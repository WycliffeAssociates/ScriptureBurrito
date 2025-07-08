using System.Text.Json;
using System.Text.Json.Serialization;
using ScriptureBurrito.Models;

namespace ScriptureBurrito;

public static class BurritoSerializer
{
    static JsonSerializerOptions SerializationOptions = new JsonSerializerOptions
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        TypeInfoResolver = BurritoContext.Default,
        Converters =
        {
            new JsonStringEnumConverter<MetaCategory>(JsonNamingPolicy.CamelCase),
            new JsonStringEnumConverter<MetaNormalization>(),
        }
    };
    public static string Serialize(BurritoSerializationRoot input)
    {
        return JsonSerializer.Serialize(input, SerializationOptions);
    }

    public static BurritoSerializationRoot? Deserialize(string input)
    {
        return JsonSerializer.Deserialize<BurritoSerializationRoot>(input, SerializationOptions);
    }
}