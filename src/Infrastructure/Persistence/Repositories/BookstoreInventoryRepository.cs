using DataAccess.Abstract;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.DataContext;
namespace DataAccess.Concrete.EntityFramework
{
    public class BookstoreInventoryRepository : EfRepositoryBase<BookstoreInventory, UniDbContext>, IBookstoreInventoryRepository
    {
        public BookstoreInventoryRepository(UniDbContext context) : base(context)
        {
        }
    }
}
