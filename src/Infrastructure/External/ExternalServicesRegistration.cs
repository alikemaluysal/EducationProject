using Application.Abstraction.Storage;
using External.Enums;
using External.Services.Storage;
using External.Services.Storage.Azure;
using Microsoft.Extensions.DependencyInjection;

namespace External
{
    public static class ExternalServicesRegistration
    {
        public static void AddExternalServices(this IServiceCollection services)
        {
            services.AddScoped<IStorageService, StorageService>();
        }
        public static void AddStorage<T>(this IServiceCollection serviceCollection) where T : Storage, IStorage //T--> IStorage'dan implemente edilmiş nesne / Concrete
        {
            serviceCollection.AddScoped<IStorage, T>();
        }
        public static void AddStorage<T>(this IServiceCollection serviceCollection, StorageType storageType) //
        {
            switch (storageType)
            {
                //case StorageType.Local:
                //    serviceCollection.AddScoped<IStorage, LocalStorage>();
                //    break;
                case StorageType.Azure:
                    serviceCollection.AddScoped<IStorage, AzureStorage>();
                    break;
                default:
                    serviceCollection.AddScoped<IStorage, AzureStorage>();
                    break;
            }
        }
    }
}
