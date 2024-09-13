using Hospital.Core.Abstractions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Hospital.Data.MsSql
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services,
            ConfigurationManager configuration)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddDbContext<ApplicationContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("SqlServer"));
            });

            services.AddAutoMapper(typeof(ApplicationContext));

            return services;
        }
    }
}
