using DataAccess.Abstract;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.DataContext;
namespace DataAccess.Concrete.EntityFramework
{
    public class ExamRepository : EfRepositoryBase<Exam, UniDbContext>, IExamRepository
    {
        public ExamRepository(UniDbContext context) : base(context)
        {
        }
    }
}
