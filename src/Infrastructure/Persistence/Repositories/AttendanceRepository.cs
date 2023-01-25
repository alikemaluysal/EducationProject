using DataAccess.Abstract;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.DataContext;
namespace DataAccess.Concrete.EntityFramework
{
    public class AttendanceRepository : EfRepositoryBase<Attendance, UniDbContext>, IAttendanceRepository
    {
        public AttendanceRepository(UniDbContext context) : base(context)
        {
        }
    }
}
