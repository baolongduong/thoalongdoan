using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PJobs.Data;

[assembly: HostingStartup(typeof(PJobs.Areas.Identity.IdentityHostingStartup))]
namespace PJobs.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<PJobsContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("PJobsContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
                 .AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<PJobsContext>();
                services.AddAuthorization(options =>
                {
                    options.AddPolicy("RequireAdministratorRole",
                     policy => policy.RequireRole("Administrator", "Candidate", "Employer"));

                });
            });
        }
    }
}