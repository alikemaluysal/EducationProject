using DataAccess.Abstract;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.DataContext;
namespace DataAccess.Concrete.EntityFramework
{
    public class StudentRepository : EfRepositoryBase<Student, UniDbContext>, IStudentRepository
    {
        public StudentRepository(UniDbContext context) : base(context)
        {
        }
    }
}
