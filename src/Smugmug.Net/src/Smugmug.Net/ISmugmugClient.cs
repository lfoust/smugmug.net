namespace Smugmug
{
    using System;
    using System.Threading.Tasks;
    using Microsoft.Framework.OptionsModel;
    using Smugmug.Http;
    using Smugmug.InternalModels;

    public interface ISmugmugClient
    {
        Task<User> GetUserAsync(string nickname);
    }

    public static class HttpClientExtensions
    {
        public static Task<string> GetJsonAsync(this IHttpClient client, string url)
        {
            throw new NotImplementedException();
        }

        public static Task<T> GetAsync<T>(this IHttpClient client, string url)
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

        public async Task<User> GetUserAsync(string nickname)
        {
            string url = this.Configuration.BaseUrl + "user/" + nickname;
            var response = await this.http.GetAsync<UserResponse>(url);
            return response.User;
        }
    }

    public class SmugmugClientConfiguration
    {
        public string BaseUrl { get; set; }
        public string ApiKey { get; set; }
        public string ApiSecret { get; set; }
    }

    public class User
    {
    }
}

namespace Smugmug.InternalModels
{
    using Newtonsoft.Json;

    internal class SmugmugResponse
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public Request Request { get; set; }
        public Options Options { get; set; }
        public Response Response { get; set; }
    }

    internal class Request
    {
    }

    internal class Options
    {
    }

    internal class Response
    {
        public string Uri { get; set; }
        public string UriDescription { get; set; }
        public string EndpointType { get; set; }
        public string Locator { get; set; }
        public string LocatorType { get; set; }
        public string ResponseLevel { get; set; }
        public string DocUri { get; set; }
        public Timing Timing { get; set; }
    }

    internal class UserResponse : Response
    {
        public User User { get; set; }
    }

    internal class Timing
    {
        public TimingMeasurement Total { get; set; }
    }

    internal class TimingMeasurement
    {
        [JsonProperty("time")]
        public double Time { get; set; }

        [JsonProperty("cycles")]
        public int Cycles { get; set; }

        [JsonProperty("objects")]
        public int Objects { get; set; }
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