
using System;
using Core.DataAccess;
using Core.Persistence.Repositories;
using Domain.Entities;
using Entities.Concrete;
namespace DataAccess.Abstract
{
    public interface IExamRepository : IRepository<Exam>
    {
    }
}