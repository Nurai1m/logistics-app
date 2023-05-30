using Application.Common.Interfaces;
using Infrastructure.Persistance;
using Infrastructure.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<LogisticEFContext>(options =>
                options.UseNpgsql(
                    configuration.GetConnectionString("Logistic"),
                    b => b.MigrationsAssembly("Infrastructure")));

            services.AddTransient<IUserService, UserService>();

            //services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
            //    .AddEntityFrameworkStores<LogisticEFContext>();

            services.AddScoped<ILogisticEFContext>(provider => provider.GetService<LogisticEFContext>());

            return services;
        }
    }
}