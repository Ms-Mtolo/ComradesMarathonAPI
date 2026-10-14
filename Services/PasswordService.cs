// Services/PasswordService.cs
using BCrypt.Net;

public static class PasswordService
{
    public static string Hash(string password) =>
        BCrypt.HashPassword(password);

    public static bool Verify(string password, string hash) =>
        BCrypt.Verify(password, hash);
}