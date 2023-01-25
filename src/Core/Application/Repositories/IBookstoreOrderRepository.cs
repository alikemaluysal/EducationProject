using Core.Persistence.Repositories;
using Domain.Entities;
namespace DataAccess.Abstract
{
    public interface IBookstoreOrderRepository : IRepository<BookstoreOrder>
    {
    }
}