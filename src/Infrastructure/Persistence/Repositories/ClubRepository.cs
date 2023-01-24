using DataAccess.Abstract;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.DataContext;
namespace DataAccess.Concrete.EntityFramework
{
    public class ClubRepository : EfRepositoryBase<Club, UniDbContext>, IClubRepository
    {
        public ClubRepository(UniDbContext context) : base(context)
        {
        }
    }
}
