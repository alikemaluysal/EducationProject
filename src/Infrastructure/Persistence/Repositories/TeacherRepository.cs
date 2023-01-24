using DataAccess.Abstract;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.DataContext;
namespace DataAccess.Concrete.EntityFramework
{
    public class TeacherRepository : EfRepositoryBase<Teacher, UniDbContext>, ITeacherRepository
    {
        public TeacherRepository(UniDbContext context) : base(context)
        {
        }
    }
}
