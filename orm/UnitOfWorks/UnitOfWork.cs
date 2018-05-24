
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using orm.Infrastructures;
using orm.Repositories;

namespace orm.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private AppDbContext _dbContext;

        public UnitOfWork(AppDbContext DbContext)
        {
            _dbContext = DbContext;
            UserRepo = new UserRepo(DbContext);
        }

        public IUserRepo UserRepo { get; private set; }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public int SaveChanges()
        {
            return _dbContext.SaveChanges();
        }
    }
}