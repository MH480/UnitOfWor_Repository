using orm.Infrastructures;
using orm.UnitOfWorks;

namespace services
{
    public abstract class BaseService
    {
        protected readonly IUnitOfWork _iUnitOfWork;
        public BaseService(AppDbContext context)
        {
            _iUnitOfWork = new UnitOfWork(context);
        }
    }
}