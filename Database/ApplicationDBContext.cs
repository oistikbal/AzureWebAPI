using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace AzureWebAPI.Database
{
    public class User : IdentityUser { }

    public class ApplicationDBContext : IdentityDbContext<User, IdentityRole, string>
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
    }

    public class ApplicationDBContextFactory : IDesignTimeDbContextFactory<ApplicationDBContext>
    {

        ApplicationDBContext IDesignTimeDbContextFactory<ApplicationDBContext>.CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDBContext>();
            optionsBuilder.UseSqlServer(Environment.GetEnvironmentVariable("AZURE_SQL_CONNECTIONSTRING"));
            return new ApplicationDBContext(optionsBuilder.Options);
        }
    }
}
