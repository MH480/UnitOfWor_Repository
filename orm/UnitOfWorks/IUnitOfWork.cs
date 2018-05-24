using System;
using orm.Repositories;

namespace orm.UnitOfWorks
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepo UserRepo { get; }
        int SaveChanges();
    }
}