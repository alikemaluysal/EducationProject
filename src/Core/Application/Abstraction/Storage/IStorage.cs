using Microsoft.AspNetCore.Http;

namespace Application.Abstraction.Storage
{
    public interface IStorage
    {
        //TODO --> storage implementation 
        Task<List<(string fileName, string pathOrContainer)>> UploadAsync(string pathOrContainer, IFormFileCollection files);
        Task DeleteAsync(string pathOrContainer, string fileName);
        List<string> GetFiles(string pathOrContainer);
        bool HasFile(string pathOrContainer, string fileName);
    }
}
