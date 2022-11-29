using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Persistence.DataContext;
namespace Persistence.ServiceRegistration
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer("Server=TEDESCO420\\SQL2019;Database=EducationProjectDb;User Id=sa;Password=qwerr112358;TrustServerCertificate=True"));
        }
    }
}
