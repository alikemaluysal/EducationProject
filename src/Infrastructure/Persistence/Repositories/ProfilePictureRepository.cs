using Application.Repositories;
using Core.Persistence.Repositories;
using Domain.Entities.FileEntities;
using Persistence.DataContext;

namespace Persistence.Repositories
{
    public class ProfilePictureRepository : EfRepositoryBase<ProfilePicture, DataContext.UniDbContext>, IProfilePictureRepository
    {
        public ProfilePictureRepository(UniDbContext context) : base(context)
        {
        }
    }
}
