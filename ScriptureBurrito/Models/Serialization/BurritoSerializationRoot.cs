namespace ScriptureBurrito.Models;

public class BurritoSerializationRoot
{
    public string Format { get; set; } = "scripture burrito";
    public Meta Meta { get; set; }
    public Dictionary<string,Authority> IdAuthorities { get; set; } = new();
    public Identification Identification { get; set; }
    public bool Confidential { get; set; } = false;
    public List<Language> Languages { get; set; } = new();
    public BurritoType Type { get; set; }
    public Copyright Copyright { get; set; }
    public Dictionary<string, LocalizedName> LocalizedNames { get; set; }
    public Dictionary<string, Ingredient> Ingredients { get; set; } = new();
}