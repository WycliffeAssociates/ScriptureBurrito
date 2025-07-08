using System.Text.Json.Serialization;

namespace ScriptureBurrito.Models;

public class Revision
{
    [JsonPropertyName("revision")]
    public string RevisionId { get; set; }
    [JsonPropertyName("timestamp")]
    public DateTime TimeStamp { get; set; }
}