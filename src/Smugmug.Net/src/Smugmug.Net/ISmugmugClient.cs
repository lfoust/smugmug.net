namespace Smugmug
{
    using Microsoft.Framework.Configuration;
    using Microsoft.Framework.OptionsModel;
    using Smugmug.Http;

    public interface ISmugmugClient
    {
    }

    public class SmugmugClient : ISmugmugClient
    {
        public SmugmugClientConfiguration Configuration { get; set; }

        private readonly IHttpClient http;

        public SmugmugClient(IHttpClient http, IOptions<SmugmugClientConfiguration> options)
        {
            this.Configuration = options.Options;
            this.http = http;
        }
    }

    public class SmugmugClientConfiguration
    {
    }
}

namespace Smugmug.Http
{
    public interface IHttpClient
    {
    }
}

namespace Smugmug.Models
{
    public class User
    {
    }
}
