namespace Application.Abstraction.Storage
{
    public interface IStorageService : IStorage
    {
        string StorageName { get; }
    }
}
