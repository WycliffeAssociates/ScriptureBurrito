namespace ScriptureBurrito.Models;

public class Ingredient
{
    public Checksum Checksum { get; set; }
    public string MimeType { get; set; }
    public uint Size { get; set; }
    public Dictionary<string, List<string>> Scope { get; set; } = new();
}