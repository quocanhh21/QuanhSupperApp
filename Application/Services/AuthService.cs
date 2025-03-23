using Application.DTOs.Requests;
using Application.DTOs.Responses;
using Application.Interface;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository _authRepository;

        public AuthService(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }

        public async Task<AuthResponse> LoginAsync(LoginRequest request)
        {
            var user = await _authRepository.GetUserByEmailAsync(request.Email);
            if (user == null || !VerifyPassword(user, request.Password))
            {
                throw new UnauthorizedAccessException("Invalid credentials");
            }

            var token = GenerateJwtToken(user);
            return new AuthResponse { Token = token, User = user };
        }

        public async Task<AuthResponse> RegisterAsync(RegisterRequest request)
        {
            var existingUser = await _authRepository.GetUserByEmailAsync(request.Email);
            if (existingUser != null)
            {
                throw new InvalidOperationException("User already exists");
            }

            var newUser = new User
            {
                Id = Guid.NewGuid().ToString(),
                Name = request.Name,
                Email = request.Email,
                PasswordHash = HashPassword(request.Password)
            };

            await _authRepository.AddUserAsync(newUser);
            var token = GenerateJwtToken(newUser);

            return new AuthResponse { Token = token, User = newUser };
        }

        private string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        private bool VerifyPassword(User user, string password)
        {
            return BCrypt.Net.BCrypt.Verify(password, user.PasswordHash);
        }

        private string GenerateJwtToken(User user)
        {
            return "MockJWTToken"; // Replace with real JWT logic
        }
    }
}
