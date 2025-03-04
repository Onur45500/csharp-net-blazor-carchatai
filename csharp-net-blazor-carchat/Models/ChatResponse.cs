using System.Text.Json.Serialization;

namespace csharp_net_blazor_carchat.Models;

public class ChatResponse
{
    [JsonPropertyName("success")]
    public bool Success { get; set; }

    [JsonPropertyName("response")]
    public string Response { get; set; } = string.Empty;

    [JsonPropertyName("error")]
    public string? Error { get; set; }
}

public class ArticleResponse
{
    [JsonPropertyName("searchUrl")]
    public string SearchUrl { get; set; } = string.Empty;

    [JsonPropertyName("articles")]
    public List<Article> Articles { get; set; } = new();
} 