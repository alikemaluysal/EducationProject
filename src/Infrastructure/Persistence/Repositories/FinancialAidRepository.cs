using DataAccess.Abstract;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.DataContext;
namespace DataAccess.Concrete.EntityFramework
{
    public class FinancialAidRepository : EfRepositoryBase<FinancialAid, UniDbContext>, IFinancialAidRepository
    {
        public FinancialAidRepository(UniDbContext context) : base(context)
        {
        }
    }
}
