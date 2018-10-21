using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApplication7.Areas.Identity.Data;
using WebApplication7.Models;

[assembly: HostingStartup(typeof(WebApplication7.Areas.Identity.IdentityHostingStartup))]
namespace WebApplication7.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<WebApplication7Context>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("WebApplication7ContextConnection")));

                services.AddDefaultIdentity<WebApplication7User>()
                    .AddEntityFrameworkStores<WebApplication7Context>();
            });
        }
    }
}