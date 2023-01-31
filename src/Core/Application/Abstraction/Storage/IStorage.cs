using Application.Dtos;
using Microsoft.AspNetCore.Http;

namespace Application.Abstraction.Storage
{
    public interface IStorage
    {
        //TODO --> storage dtoları fix, daha mantıklı bi logic kur. local storage olmayacak, sadece azure.
        //TODO --> Storage test için herhangi bir clienttan dosya upload et


        Task<List<StorageResponse>> UploadAsync(string pathOrContainer, IFormFileCollection files);
        Task DeleteAsync(string pathOrContainer, string fileName);
        List<string> GetFiles(string pathOrContainer);
        bool HasFile(string pathOrContainer, string fileName);
    }
}
