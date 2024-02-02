using Microsoft.EntityFrameworkCore;

namespace WebAPI_Server.Models
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options)
            : base(options)
        {
            
        }

        public DbSet<Users> User { get; set; }
    }
}
