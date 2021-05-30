using System.Net;
using DatasetService;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace OpenAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            Utility.CONNSTRING = configuration.GetConnectionString("myDb1");
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseHttpsRedirection();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.Use((context, next) =>
            {
                if (context.Request.Headers["x-forwarded-proto"] == "https" || context.Request.Headers["x-forwarded-for"] == "https")
                {
                    context.Request.Scheme = "https";
                }

                return next();
            });


            app.UseStaticFiles();

            app.UseRouting();

            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.All,
                RequireHeaderSymmetry = false,
                ForwardLimit = null,
                KnownNetworks = { new IPNetwork(IPAddress.Parse($"::ffff:{Configuration["HostIPAddr"]}"), 104) }
            });

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
