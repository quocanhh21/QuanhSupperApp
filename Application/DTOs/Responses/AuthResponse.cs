using Domain.Entities;

namespace Application.DTOs.Responses
{
    public class AuthResponse
    {
        public string Token { get; set; }
        public User User { get; set; }
    }
}
