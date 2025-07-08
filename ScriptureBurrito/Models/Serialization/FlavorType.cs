namespace ScriptureBurrito.Models;

public class FlavorType
{
    public string Name { get; set; } 
    public Flavor Flavor { get; set; }
    public Dictionary<string,List<string>> CurrentScope { get; set; } = new();
}