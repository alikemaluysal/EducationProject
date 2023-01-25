using Core.Persistence.Repositories;
using DataAccess.Abstract;
using Domain.Entities;
using Persistence.DataContext;

namespace DataAccess.Concrete.EntityFramework
{
    public class AdvisorRepository : EfRepositoryBase<Advisor, UniDbContext>, IAdvisorRepository
    {
        public AdvisorRepository(UniDbContext context) : base(context)
        {
        }
    }
}
