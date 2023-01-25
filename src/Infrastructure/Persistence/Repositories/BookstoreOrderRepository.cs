using DataAccess.Abstract;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.DataContext;
namespace DataAccess.Concrete.EntityFramework
{
    public class BookstoreOrderRepository : EfRepositoryBase<BookstoreOrder, UniDbContext>, IBookstoreOrderRepository
    {
        public BookstoreOrderRepository(UniDbContext context) : base(context)
        {
        }
    }
}
