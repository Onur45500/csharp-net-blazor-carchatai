using System.Text.Json.Serialization;

namespace csharp_net_blazor_carchat.Models
{
    public class FilterRequest
    {
        [JsonPropertyName("cars")]
        public List<Article> Cars { get; set; } = new();

        [JsonPropertyName("filterQuery")]
        public string FilterQuery { get; set; } = string.Empty;

        // Add validation to prevent filtering selected cars
        public bool IsValid()
        {
            return Cars.All(car => !car.IsSelected);
        }
    }

    public class FilterResponse
    {
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        [JsonPropertyName("response")]
        public string Response { get; set; } = string.Empty;

        [JsonPropertyName("error")]
        public string? Error { get; set; }
    }

    public class FilterResult
    {
        [JsonPropertyName("filtered_car_ids")]
        public List<int> FilteredCarIds { get; set; } = new();

        [JsonPropertyName("explanation")]
        public string Explanation { get; set; } = string.Empty;
    }
} 