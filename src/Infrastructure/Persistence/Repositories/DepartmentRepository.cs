using DataAccess.Abstract;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.DataContext;
namespace DataAccess.Concrete.EntityFramework
{
    public class DepartmentRepository : EfRepositoryBase<Department, UniDbContext>, IDepartmentRepository
    {
        public DepartmentRepository(UniDbContext context) : base(context)
        {
        }
    }
}
