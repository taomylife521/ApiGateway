using System.Linq;
using ApiGateway.Core.Contexts;
using ApiGateway.Core.Exceptions;
using ApiGateway.Core.Filters;
using ApiGateway.Core.IoC;
using ApiGateway.Core.Providers;

namespace ApiGateway.Filters
{
    public class IPFilter : IFilter
    {
        private readonly IIPProvider _provider = ObjectContainer.Resolve<IIPProvider>();

        public FilterType FilterType => FilterType.Pre;
        public int FilterOrder => 30;

        public void Execute()
        {
            string ipAddress = GetClientIPAddress();
            var blacklist = _provider.GetIPBlacklist();

            if (blacklist.Contains(ipAddress))
                throw new ApiGatewayException(403, "Forbidden");
        }

        private string GetClientIPAddress()
        {
            var request = RequestContext.Current.Request;
            return request.HttpContext.Connection.RemoteIpAddress.AddressFamily.ToString();
        }
    }
}
