
using System;
using System.Linq;
using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using DataAccess.Concrete.EntityFramework.Contexts;
using DataAccess.Abstract;
namespace DataAccess.Concrete.EntityFramework
{
    public class HousingRepository : EfRepositoryBase<Housing, UniDbContext>, IHousingRepository
    {
        public HousingRepository(UniDbContext context) : base(context)
        {
        }
    }
}
