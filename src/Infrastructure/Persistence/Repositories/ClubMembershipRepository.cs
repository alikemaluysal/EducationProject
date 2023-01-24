using DataAccess.Abstract;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.DataContext;
namespace DataAccess.Concrete.EntityFramework
{
    public class ClubMembershipRepository : EfRepositoryBase<ClubMembership, UniDbContext>, IClubMembershipRepository
    {
        public ClubMembershipRepository(UniDbContext context) : base(context)
        {
        }
    }
}
