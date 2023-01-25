using Core.Persistence.Repositories;
using DataAccess.Abstract;
using Domain.Entities;
using Persistence.DataContext;

namespace DataAccess.Concrete.EntityFramework
{
    public class HousingRepository : EfRepositoryBase<Housing, UniDbContext>, IHousingRepository
    {
        public HousingRepository(UniDbContext context) : base(context)
        {
        }
    }
}
