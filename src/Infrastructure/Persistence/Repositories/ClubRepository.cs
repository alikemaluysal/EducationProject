using Core.Persistence.Repositories;
using DataAccess.Abstract;
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
