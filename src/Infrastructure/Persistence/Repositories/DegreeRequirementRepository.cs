using DataAccess.Abstract;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.DataContext;

namespace DataAccess.Concrete.EntityFramework
{
    public class DegreeRequirementRepository : EfRepositoryBase<DegreeRequirement, UniDbContext>, IDegreeRequirementRepository
    {
        public DegreeRequirementRepository(UniDbContext context) : base(context)
        {
        }
    }
}
