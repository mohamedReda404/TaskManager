using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using Task_Manager.Persistence;

namespace Task_Manager
{
    public static class DepandencyInjection
    {
        public static IServiceCollection ApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IServiceTask, ServiceTask>();
            services.AddScoped<IServiceUser, ServiceUser>();
            return services;
        }

        public static IServiceCollection AddSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen();
            return services;
        }

        public static IServiceCollection AddDBConfig(this IServiceCollection services,IConfiguration configuration)
        {
            var coneectionDb = configuration.GetConnectionString("Connection");
            services.AddDbContext<AppDbContext>(o => o.UseSqlServer(coneectionDb));
            return services;
        }
    }
}
