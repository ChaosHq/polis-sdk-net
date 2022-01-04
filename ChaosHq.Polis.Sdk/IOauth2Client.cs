namespace ChaosHq.Polis.Sdk;

public interface IOauth2Client
{
    IOauth2User? Oauth2User { get; set; }

    public string StartOauth2(string appId, string returnUrl);

    public void SetUser(IOauth2User oauth2User);

    public void RefreshToken(string appId, string refreshToken, Action? callback);

    public Task RefreshTokenAsync(string appId, string refreshToken);

    public Task GetUserInfoAsync(string accessToken);
}