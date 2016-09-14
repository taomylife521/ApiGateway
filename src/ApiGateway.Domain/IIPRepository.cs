namespace ApiGateway.Domain
{
    public interface IIPRepository
    {
        string[] GetIPBlacklist();
    }
}
