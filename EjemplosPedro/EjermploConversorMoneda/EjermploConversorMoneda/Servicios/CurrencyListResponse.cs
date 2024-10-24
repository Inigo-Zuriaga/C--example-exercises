using System.Text.Json.Serialization;

public class CurrencyListResponse
{
    [JsonPropertyName("rates")]
    public Dictionary<string, decimal> rates { get; set; }
}
