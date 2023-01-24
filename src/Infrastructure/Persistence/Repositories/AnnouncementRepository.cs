using System;
using System.Linq;
using DataAccess.Abstract;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.DataContext;

namespace DataAccess.Concrete.EntityFramework
{
    public class AnnouncementRepository : EfRepositoryBase<Announcement, UniDbContext>, IAnnouncementRepository
    {
        public AnnouncementRepository(UniDbContext context) : base(context)
        {
        }
    }
}
