using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace ProfileService.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .UseUrls("http://0.0.0.0:54272")
                .UseStartup<Startup>();
    }
}
