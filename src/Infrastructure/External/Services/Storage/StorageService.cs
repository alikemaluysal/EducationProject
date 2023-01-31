using Application.Abstraction.Storage;
using Application.Dtos;

namespace External.Services.Storage
{
    public class StorageService : IStorageService
    {
        readonly IStorage _storage;

        public StorageService(IStorage storage)
        {
            _storage = storage;
        }

        public string StorageName { get => _storage.GetType().Name; }

        public async Task DeleteAsync(string path, string fileName)
        {
            await _storage.DeleteAsync(path, fileName);
        }

        public List<string> GetFiles(string path)
        {
            return _storage.GetFiles(path);
        }

        public bool HasFile(string path, string fileName)
        {
            return _storage.HasFile(path, fileName);
        }

        public async Task<List<StorageResponse>> UploadAsync(string path, Microsoft.AspNetCore.Http.IFormFileCollection files)
        {
            return await _storage.UploadAsync(path, files);
        }
    }
}
