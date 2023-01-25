using Core.Persistence.Repositories;
using DataAccess.Abstract;
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
