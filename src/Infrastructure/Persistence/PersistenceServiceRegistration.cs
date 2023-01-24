using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Configuration;
using Persistence.DataContext;
namespace Persistence.ServiceRegistration
{
    public static class PersistenceServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<UniDbContext>(options => options.UseSqlServer(ConnectionStringConfiguration.connectionString));
            //services.AddDbContext<UniDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnectionString")));            
        }
    }
}
