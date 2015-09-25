namespace Smugmug
{
    using System.Net.Http;
    using System.Threading.Tasks;
    using Microsoft.Framework.OptionsModel;
    using Smugmug.InternalModels;

    public class SmugmugClient : ISmugmugClient
    {
        public SmugmugClientConfiguration Configuration { get; set; }

        private readonly HttpClient httpClient;

        public SmugmugClient(IOptions<SmugmugClientConfiguration> options)
        {
            this.Configuration = options.Options;
            this.httpClient = new HttpClient(this.Configuration.MessageHandler ?? new HttpClientHandler());
        }

        public async Task<User> GetUserAsync(string nickname)
        {
            string url = this.Configuration.BaseUrl + "user/" + nickname;
            var response = await this.httpClient.GetAsync<UserResponse>(url);
            return response.User;
        }
    }
}