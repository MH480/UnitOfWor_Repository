using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;

namespace orm.Infrastructures
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var OptionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            OptionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EFGetStarted.AspNetCore.NewDb;Trusted_Connection=True;ConnectRetryCount=0");
            return new AppDbContext(OptionsBuilder.Options);
        }
    }
}