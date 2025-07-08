using System.Text.Json.Serialization;

namespace ScriptureBurrito.Models;

public class Checksum
{
    [JsonPropertyName("md5")]
    public string MD5 { get; set; }
    [JsonPropertyName("sha3-256")]
    public string SHA256 { get; set; }
    [JsonPropertyName("sha3-512")]
    public string SHA512 { get; set; }
}