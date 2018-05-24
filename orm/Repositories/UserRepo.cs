using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using orm.Infrastructures;
using orm.OrmModels;
using orm.Repositories.Base;

namespace orm.Repositories
{
    public class UserRepo : Repository<AppUser>, IUserRepo
    {
        public UserRepo(AppDbContext dbcontext) : base(dbcontext)
        {
            
        }


        public IEnumerable<AppUser> GetActivatedUsers()
        {
            return _dbcontext.tbAppUsers.Where(x => x.IsActivated);
        }

        

        public int GetUserCount()
        {
            return _dbcontext.tbAppUsers.Count();
        }
    }
}