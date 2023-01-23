using Microsoft.Extensions.Configuration;

namespace Persistence.Configuration
{
    static class ConnectionStringConfiguration
    {
        public static string connectionString
        {
            get
            {
                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../../Presentation/API/API"));
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager.GetConnectionString("DefaultConnectionString");
            }
        }
    }
}
