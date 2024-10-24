using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;

namespace EjermploConversorMoneda.Services
{
    public class CurrencyConverterService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey = "4b98ce431c662ac85c443184";

        public CurrencyConverterService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<decimal> ConvertCurrency(decimal amount, string fromCurrency, string toCurrency)
        {
            var requestUrl = $"https://v6.exchangerate-api.com/v6/{_apiKey}/pair/{fromCurrency}/{toCurrency}/{amount}";

            var response = await _httpClient.GetAsync(requestUrl);
            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                var conversionResult = System.Text.Json.JsonSerializer.Deserialize<ConversionResponse>(jsonResponse);
                return conversionResult.ConversionRate * amount;
            }
            else
            {
                throw new Exception("Error al obtener la tasa de conversi�n.");
            }
        }

        //public async Task<List<string>> GetCurrencyList()
        //{
        //    var response = await _httpClient.GetAsync("https://api.exchangerate-api.com/v4/latest/USD");
        //    response.EnsureSuccessStatusCode();
        //    var content = await response.Content.ReadAsStringAsync();
        //    var currencyListResponse = JsonSerializer.Deserialize<CurrencyListResponse>(content);
        //    return currencyListResponse.Rates.Keys.ToList();
        //}

        //public async Task<List<string>> GetCurrencyList()
        //{
        //    var response = await _httpClient.GetAsync("https://api.exchangerate-api.com/v4/latest/USD");

        //    if (response.IsSuccessStatusCode)
        //    {
        //        var content = await response.Content.ReadAsStringAsync();
        //        var currencyListResponse = JsonConvert.DeserializeObject<CurrencyListResponse>(content);
        //        var currencyCodes = currencyListResponse.Rates.Keys.ToList();
        //        return currencyCodes;
        //    }

        //    return new List<string>();
        //}

        public async Task<List<string>> GetCurrencyList()
        {
            var response = await _httpClient.GetAsync("https://api.exchangerate-api.com/v4/latest/USD");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var currencyListResponse = System.Text.Json.JsonSerializer.Deserialize<CurrencyListResponse>(content);
                var currencyCodes = currencyListResponse.rates.Keys.ToList();
                return currencyCodes;
            }

            return new List<string>();
        }

    }
}
