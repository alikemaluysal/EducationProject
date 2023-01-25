
using System;
using Core.Persistence.Repositories;
using Domain.Entities;
namespace DataAccess.Abstract
{
    public interface ICourseRepository : IRepository<Course>
    {
    }
}