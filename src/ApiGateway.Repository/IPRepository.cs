using System.Linq;
using ApiGateway.Domain;

namespace ApiGateway.Repository
{
    public class IPRepository : IIPRepository
    {
        public string[] GetIPBlacklist()
        {
            string key = CacheHelper.MakeCacheKey(CacheKeys.IPBlacklist);
            return Redis.Db.SetMembers(key).Select(i => i.ToString()).ToArray();
        }
    }
}
