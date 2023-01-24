using DataAccess.Abstract;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.DataContext;
namespace DataAccess.Concrete.EntityFramework
{
    public class ExamScoreRepository : EfRepositoryBase<ExamScore, UniDbContext>, IExamScoreRepository
    {
        public ExamScoreRepository(UniDbContext context) : base(context)
        {
        }
    }
}
