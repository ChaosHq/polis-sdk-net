namespace ChaosHq.Polis.Sdk;

public interface IMiddlewareClient
{
    public IUserProfile GetProfile(string accessToken);
}