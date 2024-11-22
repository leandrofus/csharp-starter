namespace test3.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string RefreshToken { get; set; } // Agregar el campo para el refresh token
        public DateTime RefreshTokenExpiryTime { get; set; }
    }
    public class RefreshTokenRequest
    {
        public string Token { get; set; }
    }
}