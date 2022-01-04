namespace ChaosHq.Polis.Sdk;

public interface IOauth2User
{
    public string AccessToken { get; set; }
    public string? AppId { get; set; }
    public string? AppName { get; set; }
    public string? RefreshToken { get; set; }
    public long? ExpiresIn { get; set; }
    public string? Username { get; set; }
    public long? ExpriesAt { get; set; }
}