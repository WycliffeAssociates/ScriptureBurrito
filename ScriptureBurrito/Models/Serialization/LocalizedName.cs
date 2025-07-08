using System.Text.Json.Serialization;

namespace ScriptureBurrito.Models;

public class LocalizedName
{
    public Dictionary<string, string> Short { get; set; } = new();
    [JsonPropertyName("abbr")]
    public Dictionary<string, string> Abbreviation { get; set; } = new();
    public Dictionary<string, string> Long { get; set; } = new();
}