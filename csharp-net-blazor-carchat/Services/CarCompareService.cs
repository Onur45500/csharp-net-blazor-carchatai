using System.Net.Http.Json;
using csharp_net_blazor_carchat.Models;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace csharp_net_blazor_carchat.Services;

public class CarCompareService
{
    private readonly HttpClient _httpClient;
    private readonly ILogger<CarCompareService> _logger;

    public CarCompareService(IHttpClientFactory httpClientFactory, ILogger<CarCompareService> logger)
    {
        _httpClient = httpClientFactory.CreateClient("ChatAPI");
        _logger = logger;
    }

    public async Task<string> CompareAsync(CompareRequest request)
    {
        try 
        {
            _logger.LogInformation("Sending comparison request to: {Url}", _httpClient.BaseAddress + "api/compare/analyze");
            var response = await _httpClient.PostAsJsonAsync("api/compare/analyze", request);
            _logger.LogInformation("Received response with status: {StatusCode}", response.StatusCode);
            
            response.EnsureSuccessStatusCode();
            
            var compareResponse = await response.Content.ReadFromJsonAsync<CompareResponse>();
            
            if (compareResponse?.Success != true)
            {
                throw new Exception(compareResponse?.Error ?? "Comparison failed");
            }
            
            return compareResponse.Response;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error during car comparison request");
            throw;
        }
    }

    public async Task<FilterResult> FilterCarsAsync(FilterRequest request)
    {
        try
        {
            _logger.LogInformation("Sending filter request to endpoint: {Endpoint}", "chat/filter");
            
            var response = await _httpClient.PostAsJsonAsync("chat/filter", request);
            response.EnsureSuccessStatusCode();
            
            var content = await response.Content.ReadAsStringAsync();
            _logger.LogInformation("Raw response from filter endpoint: {Response}", content);
            
            var filterResponse = JsonSerializer.Deserialize<FilterResponse>(content);
            
            if (filterResponse?.Success != true)
            {
                _logger.LogWarning("Filter response indicates failure: {Error}", filterResponse?.Error);
                throw new Exception(filterResponse?.Error ?? "Filter operation failed");
            }

            _logger.LogInformation("Filter response success, response content: {Response}", filterResponse.Response);

            // Deserialize the nested response string
            var result = JsonSerializer.Deserialize<FilterResult>(filterResponse.Response);
            _logger.LogInformation("Deserialized filter result: IDs={Ids}, Explanation={Explanation}", 
                string.Join(", ", result?.FilteredCarIds ?? new List<int>()),
                result?.Explanation);
            
            return result ?? new FilterResult();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error during car filtering");
            throw;
        }
    }
} 