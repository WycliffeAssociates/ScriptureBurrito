namespace ScriptureBurrito.Models;

public class Meta
{
    // Only valid version is 1.0.0 at the moment
    public string Version { get; set; } = "1.0.0";
    public MetaCategory Category { get; set; }
    public Generator Generator { get; set; }
    public string DefaultLocale { get; set; }
    public DateTime DateCreated { get; set; }
    /// <summary>
    /// Possible values NFC, NFD, NFKC, NFKD
    /// </summary>
    public MetaNormalization Normalization { get; set; }
}