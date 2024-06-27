using blazorAuthen.DTOs;
using static blazorAuthen.Responses.CustomResponses;

namespace blazorAuthen.Services
{
    public interface IAccountService
    {
        Task<RegistrationResponse> RegisterAsync(RegisterDTO model);
        Task<LoginResponse> LoginAsync(LoginDTO model);
        Task<WeatherForecast[]> GetWeatherForecasts();
    }
}