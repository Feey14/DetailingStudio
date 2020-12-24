using System;
using DetailingStudio.Areas.Identity.Data;
using DetailingStudio.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(DetailingStudio.Areas.Identity.IdentityHostingStartup))]
namespace DetailingStudio.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<DetailingStudioContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("DetailingStudioContextConnection")));

                services.AddDefaultIdentity<DetailingStudioUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<DetailingStudioContext>();
            });
        }
    }
}