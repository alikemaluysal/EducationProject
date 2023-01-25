using Core.Persistence.Repositories;
using DataAccess.Abstract;
using Domain.Entities;
using Persistence.DataContext;

namespace DataAccess.Concrete.EntityFramework
{
    public class ClassRepository : EfRepositoryBase<Class, UniDbContext>, IClassRepository
    {
        public ClassRepository(UniDbContext context) : base(context)
        {
        }
    }
}
