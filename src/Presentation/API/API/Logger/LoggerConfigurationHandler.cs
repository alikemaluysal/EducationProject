using Microsoft.AspNetCore.HttpLogging;
using Serilog;
using Serilog.Core;

namespace API.LoggerConfigurationHandler
{
    public static class LoggerConfigurationHandler
    {
        public static Logger GetLogger(IConfiguration configuration)
        {
            Logger logger = new LoggerConfiguration().WriteTo.Console().
                WriteTo.File("logs/log.txt").
                WriteTo.MSSqlServer(
                connectionString: configuration.GetConnectionString("DefaultConnectionString"),
                sinkOptions: new Serilog.Sinks.MSSqlServer.MSSqlServerSinkOptions
                {
                    AutoCreateSqlTable = true,
                    TableName = "Logs",
                    EagerlyEmitFirstEvent = true,
                }).Enrich.FromLogContext().
                MinimumLevel.Information()
                .CreateLogger();
            return logger;
        }

        public static void AddHttpLogging(this IServiceCollection services)
        {
            services.AddHttpLogging(logging =>
            {
                logging.LoggingFields = HttpLoggingFields.All;
                logging.RequestHeaders.Add("sec-ch-ua");
                logging.MediaTypeOptions.AddText("application/javascript");
                logging.RequestBodyLogLimit = 4096;
                logging.ResponseBodyLogLimit = 4096;
            });
        }
    }
}
