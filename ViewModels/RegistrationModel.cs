namespace Church_Solution_API.ViewModels
{
    public class RegistrationModel
    {
        public string Email { get; set; }
        public string SecurityStamp { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; }
    }

    public class LoginModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class LoginResponse
    {
        public string? Status { get; set; }
        public string? Message { get; set; }
    }

    public class TokenModel
    {
        public string? AccessToken { get; set; }
        public string? RefreshToken { get; set; }
    }
}
