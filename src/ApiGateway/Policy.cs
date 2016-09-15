using Microsoft.Extensions.Configuration;

namespace ApiGateway
{
    public class Policy
    {
        private static readonly Policy Instance = new Policy();

        public static Policy Default => Instance;

        /// <summary>
        /// Response timeout in seconds
        /// </summary>
        public int Timeout { get; set; }

        /// <summary>
        /// Times to be allowed to request per minute
        /// </summary>
        public int Limit { get; set; }

        public static void Parse(IConfiguration configuration)
        {
            if (configuration == null) return;

            Instance.Timeout = configuration.GetValue<int>("Timeout");
            Instance.Limit = configuration.GetValue<int>("Limit");
        }
    }
}
