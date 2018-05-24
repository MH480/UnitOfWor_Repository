using System.Collections.Generic;
using orm.OrmModels;
using orm.Repositories.Base;

namespace orm.Repositories  
{
    public interface IUserRepo : IRepository<AppUser>
    {
        int GetUserCount();
        IEnumerable<AppUser> GetActivatedUsers();
    }
}