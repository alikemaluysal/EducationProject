using DataAccess.Abstract;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.DataContext;
namespace DataAccess.Concrete.EntityFramework
{
    public class MealPlanRepository : EfRepositoryBase<MealPlan, UniDbContext>, IMealPlanRepository
    {
        public MealPlanRepository(UniDbContext context) : base(context)
        {
        }
    }
}
