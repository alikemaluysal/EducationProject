using Application.Abstraction.Storage;
using Application.Repositories;
using DataAccess.Abstract;
using Domain.Entities.FileEntities;
using MediatR;

namespace Application.Features.Students.Commands.UploadProfilePicture
{
    public class UploadStudentProfilePicCommandHandler : IRequestHandler<UploadStudentProfilePicCommandRequest, bool>
    {
        readonly IStorageService _storageService;
        readonly IStudentRepository _studentRepository;
        readonly IProfilePictureRepository _profilePicRepository;

        public UploadStudentProfilePicCommandHandler(IStorageService storageService, IStudentRepository studentRepository, IProfilePictureRepository profilePicRepository)
        {
            _storageService = storageService;
            _studentRepository = studentRepository;
            _profilePicRepository = profilePicRepository;
        }

        public async Task<bool> Handle(UploadStudentProfilePicCommandRequest request, CancellationToken cancellationToken)
        {
            var student = _studentRepository.Get(x => x.Id == Guid.Parse(request.StudentId));
            var collectionData = await _storageService.UploadAsync("profile-pictures", request.Files);
            var data = collectionData.FirstOrDefault();
            if (data != null)
            {
                ProfilePicture profilePic = new()
                {
                    Id = Guid.NewGuid(),
                    FileName = data.FileName,
                    Path = data.Path,
                    Storage = _storageService.StorageName,
                    CreatedDate = DateTime.Now,

                };
                student.ProfilePictureId = profilePic.Id;
                _studentRepository.Update(student);
                return true;
            }
            return false;
        }
    }
}
