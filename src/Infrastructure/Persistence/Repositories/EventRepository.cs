using DataAccess.Abstract;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.DataContext;
namespace DataAccess.Concrete.EntityFramework
{
    public class EventRepository : EfRepositoryBase<Event, UniDbContext>, IEventRepository
    {
        public EventRepository(UniDbContext context) : base(context)
        {
        }
    }
}
