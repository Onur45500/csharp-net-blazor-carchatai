using System.Text.Json.Serialization;

namespace csharp_net_blazor_carchat.Models;

public class Article
{
    [JsonPropertyName("Id")]
    public int Id { get; set; }

    [JsonPropertyName("Title")]
    public string Title { get; set; } = string.Empty;

    [JsonPropertyName("Price")]
    public string Price { get; set; } = string.Empty;

    [JsonPropertyName("Location")]
    public string Location { get; set; } = string.Empty;

    [JsonPropertyName("Url")]
    public string Url { get; set; } = string.Empty;

    [JsonPropertyName("Description")]
    public string Description { get; set; } = string.Empty;

    [JsonPropertyName("Attributes")]
    public Dictionary<string, string> Attributes { get; set; } = new();

    [JsonPropertyName("Images")]
    public List<string> Images { get; set; } = new();

    [JsonIgnore]
    public bool IsSelected { get; set; }
} 