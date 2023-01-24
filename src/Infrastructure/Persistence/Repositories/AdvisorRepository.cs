
using System;
using System.Linq;
using DataAccess.Abstract;
using Persistence.DataContext;
using Domain.Entities;
using Core.Persistence.Repositories;

namespace DataAccess.Concrete.EntityFramework
{
    public class AdvisorRepository : EfRepositoryBase<Advisor, UniDbContext>, IAdvisorRepository
    {
        public AdvisorRepository(UniDbContext context) : base(context)
        {
        }
    }
}
