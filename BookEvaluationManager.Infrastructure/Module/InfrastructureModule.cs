using BookEvaluationManager.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BookEvaluationManager.Infrastructure.Module
{
    public static class InfrastructureModule
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddServices(configuration);

            return services;
        }

        private static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("LocalhostConnection");

            services.AddDbContext<BookEvaluationManagerContext>(options =>
                options.UseSqlServer(connectionString));

            return services;
        }
    }
}
