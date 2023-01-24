using DataAccess.Abstract;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.DataContext;
namespace DataAccess.Concrete.EntityFramework
{
    public class ResourceRepository : EfRepositoryBase<Resource, UniDbContext>, IResourceRepository
    {
        public ResourceRepository(UniDbContext context) : base(context)
        {
        }
    }
}
