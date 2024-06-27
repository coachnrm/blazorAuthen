using Azure;
using blazorAuthen.DTOs;
using blazorAuthen.Responses;
using blazorAuthen.States;
using static blazorAuthen.Responses.CustomResponses;

namespace blazorAuthen.Services
{
    public class AccountService : IAccountService
    {
        private readonly HttpClient httpClient;
        public AccountService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        private const string BaseUrl = "api/account";

        public async Task<WeatherForecast[]> GetWeatherForecasts()
        {
            if(Constants.JWTToken == "") return null;
            httpClient.DefaultRequestHeaders.Authorization = 
                new System.Net.Http.Headers.AuthenticationHeaderValue("Bearere",Constants.JWTToken);
            return await httpClient.GetFromJsonAsync<WeatherForecast[]>($"{BaseUrl}/weather");
        }

        public async Task<LoginResponse> LoginAsync(LoginDTO model)
        {
            var response = await httpClient.PostAsJsonAsync($"{BaseUrl}/login", model);
            var result = await response.Content.ReadFromJsonAsync<LoginResponse>();
            return result!;
        }

        public async Task<RegistrationResponse> RegisterAsync(RegisterDTO model)
        {
            var respose = await httpClient.PostAsJsonAsync($"{BaseUrl}/register", model);
            var result = await respose.Content.ReadFromJsonAsync<RegistrationResponse>();
            return result!;
        }
    }
}