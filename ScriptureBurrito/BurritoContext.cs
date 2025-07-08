using System.Text.Json;
using System.Text.Json.Serialization;
using ScriptureBurrito.Models;

namespace ScriptureBurrito;


[JsonSerializable(typeof(BurritoSerializationRoot))]
internal partial class BurritoContext: JsonSerializerContext
{
    
}

internal class CamelCaseEnumConverter<TEnum>()
    : JsonStringEnumConverter<TEnum>(JsonNamingPolicy.CamelCase) where TEnum : struct, Enum
{
    
}