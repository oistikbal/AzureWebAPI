using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace AzureWebAPI.Database
{
    public class User : IdentityUser { }

    public class ApplicationDBContext : IdentityDbContext<User>
    {
    }
}
