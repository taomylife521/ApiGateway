namespace ApiGateway.Core.Providers
{
    public interface IIPProvider
    {
        string[] GetIPBlacklist();
    }
}
