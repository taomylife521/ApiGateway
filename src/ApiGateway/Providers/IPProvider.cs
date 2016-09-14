using ApiGateway.Core.IoC;
using ApiGateway.Core.Providers;
using ApiGateway.Domain;

namespace ApiGateway.Providers
{
    public class IPProvider : IIPProvider
    {
        private readonly IIPRepository _ipRepository = ObjectContainer.Resolve<IIPRepository>();

        public string[] GetIPBlacklist()
        {
            return _ipRepository.GetIPBlacklist();
        }
    }
}
