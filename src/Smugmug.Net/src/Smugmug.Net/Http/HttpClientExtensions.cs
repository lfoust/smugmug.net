namespace Smugmug
{
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    public static class HttpClientExtensions
    {
        public static async Task<string> GetJsonAsync(this HttpClient client, string url)
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
            requestMessage.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            using (var responseMessage = await client.SendAsync(requestMessage))
            {
                if (responseMessage.IsSuccessStatusCode)
                {
                    string json = await responseMessage.Content.ReadAsStringAsync();
                    return json;
                }
            }

            return null;
        }

        public static async Task<T> GetAsync<T>(this HttpClient client, string url)
        {
            string json = await client.GetJsonAsync(url);
            if (string.IsNullOrEmpty(json))
            {
                return default(T);
            }

            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}