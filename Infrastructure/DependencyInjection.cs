using Application.Common;
using Infrastructure.Persistance;
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

            services.AddScoped<ILogisticEFContext>(provider => provider.GetService<LogisticEFContext>());

            return services;
        }
    }
}