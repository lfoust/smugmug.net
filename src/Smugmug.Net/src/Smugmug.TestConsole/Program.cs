namespace Smugmug.TestConsole
{
    using System;
    using System.Threading.Tasks;
    using Microsoft.Framework.Configuration;
    using Microsoft.Framework.DependencyInjection;
    using Microsoft.Framework.OptionsModel;

    public class Program
    {
        public void Main(string[] args)
        {
            Go().Wait();
            Console.WriteLine("Done");
            Console.ReadLine();
        }

        static async Task Go()
        {
            var builder = new ConfigurationBuilder(@"D:\Code\smugmug.net\src\Smugmug.Net\src\Smugmug.TestConsole")
                .AddJsonFile("config.json");
            var configuration = builder.Build();


            IOptions<SmugmugClientConfiguration> options = new OptionsManager<SmugmugClientConfiguration>();

            SmugmugClient client = new SmugmugClient(options);
            var user = await client.GetUserAsync("foustfamily");
        }
    }
}
