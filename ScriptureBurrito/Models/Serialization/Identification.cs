namespace ScriptureBurrito.Models;

public class Identification
{
    public Dictionary<string, Dictionary<string, Revision>> Primary { get; set; } = new ();
    public Dictionary<string, string> Name { get; set; } = new();
    public Dictionary<string, string> Abbreviation { get; set; } = new();
}