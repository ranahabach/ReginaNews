using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(ReginaNews.Areas.Identity.IdentityHostingStartup))]
namespace ReginaNews.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}