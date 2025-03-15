using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace AzureWebAPI.Database
{
    public class User : IdentityUser { }

    public class ApplicationDBContext : IdentityDbContext<User>
    {
    }
}
