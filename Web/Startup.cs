using Application;
using Infrastructure;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication()
                .AddInfrastructure(Configuration);

            services.AddHttpContextAccessor();
            services
                .AddControllersWithViews();

            services.ConfigureApplicationCookie(options =>
            {
                options.AccessDeniedPath = new PathString("/error/403");
                options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
                options.LoginPath = "/account/login";
                options.LogoutPath = "/home/index";
                options.ReturnUrlParameter = CookieAuthenticationDefaults.ReturnUrlParameter;
                options.SlidingExpiration = true;
                options.Cookie.IsEssential = true;
                options.Cookie.HttpOnly = true;
                options.Cookie.SameSite = SameSiteMode.Strict;
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseAuthentication();
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
