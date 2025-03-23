using Application.DTOs.Requests;
using Application.DTOs.Responses;

namespace Application.Interface
{
    public interface IAuthService
    {
        Task<AuthResponse> LoginAsync(LoginRequest request);
        Task<AuthResponse> RegisterAsync(RegisterRequest request);
    }
}
