namespace Smugmug
{
    using System;
    using System.Threading.Tasks;
    using Microsoft.Framework.OptionsModel;
    using Smugmug.Http;

    public interface ISmugmugClient
    {
        Task<User> GetUserAsync(string userId);
    }

    public static class HttpClientExtensions
    {
        public static string GetJson(this IHttpClient client, string url)
        {
            throw new NotImplementedException();
        }
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

        public Task<User> GetUserAsync(string userId)
        {
            throw new System.NotImplementedException();
        }
    }

    public class SmugmugClientConfiguration
    {
    }

    public class User
    {
    }
}

namespace Smugmug.Http
{
    using System.Threading.Tasks;

    public interface IHttpClient
    {
        Task<IHttpResponse> MakeRequestAsync(IHttpRequest request);
    }

    public interface IHttpRequest
    {
    }

    public interface IHttpResponse
    {
    }
}