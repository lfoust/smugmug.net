namespace Smugmug
{
    using System.Net.Http;

    public class SmugmugClientConfiguration
    {
        public string BaseUrl { get; set; }
        public string ApiKey { get; set; }
        public string ApiSecret { get; set; }

        public HttpMessageHandler MessageHandler { get; set; }
    }
}