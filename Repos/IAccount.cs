using blazorAuthen.DTOs;
using static blazorAuthen.Responses.CustomResponses;

namespace blazorAuthen.Repos
{
    public interface IAccount
    {
        Task<RegistrationResponse> RegisterAsync(RegisterDTO model);
        Task<LoginResponse> LoginAsync(LoginDTO model);
        LoginResponse RefreshToken(UserSession userSession);
    }
}