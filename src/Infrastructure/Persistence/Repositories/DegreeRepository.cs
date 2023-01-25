using DataAccess.Abstract;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.DataContext;
namespace DataAccess.Concrete.EntityFramework
{
    public class DegreeRepository : EfRepositoryBase<Degree, UniDbContext>, IDegreeRepository
    {
        public DegreeRepository(UniDbContext context) : base(context)
        {
        }
    }
}
