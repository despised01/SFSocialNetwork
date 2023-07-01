using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SFSocialNetwork
{
    public class ApplicationDbContext : IdentityDbContext <User>
    {
        public ApplicationDbContext(DbContextOptions <ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
