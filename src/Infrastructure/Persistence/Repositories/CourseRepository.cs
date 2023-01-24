using DataAccess.Abstract;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.DataContext;
namespace DataAccess.Concrete.EntityFramework
{
    public class CourseRepository : EfRepositoryBase<Course, UniDbContext>, ICourseRepository
    {
        public CourseRepository(UniDbContext context) : base(context)
        {
        }
    }
}
