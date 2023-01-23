using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.DataContext;
namespace Persistence.ServiceRegistration
{
    public static class ServiceRegistration
    {

        public static void AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<UniDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnectionString")));
        }
    }
}
