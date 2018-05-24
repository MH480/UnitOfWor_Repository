using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using orm.OrmModels;

namespace orm.Infrastructures
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext() : base()
        {
            
        }

        public DbSet<AppUser> tbAppUsers { get; set; }
    }
}