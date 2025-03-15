using Authentication_and_Authorization___JWT_Tokens.Models;
using Microsoft.EntityFrameworkCore;

namespace Authentication_and_Authorization___JWT_Tokens.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
    }
   
}
