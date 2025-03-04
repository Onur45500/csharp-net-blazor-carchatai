namespace csharp_net_blazor_carchat.Models;

public class CompareRequest
{
    public List<Article> Cars { get; set; } = new();
    public string Question { get; set; } = string.Empty;
} 