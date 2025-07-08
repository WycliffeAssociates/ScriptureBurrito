namespace ScriptureBurrito.Models;

public class Authority
{
    public string Id { get; set; }
    public Dictionary<string, string>  Name { get; set; } = new();
}