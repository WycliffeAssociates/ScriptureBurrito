namespace ScriptureBurrito.Models;

public class Language
{
    public string Tag { get; set; }
    public Dictionary<string,string> Name { get; set; } = new();
    public string ScriptDirection { get; set; } = "ltr";
}