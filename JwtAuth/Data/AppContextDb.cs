using Microsoft.EntityFrameworkCore;
using JwtAuth.Models;

namespace JwtAuth.Data
{
    public class AppContextDb : DbContext
    {
        public AppContextDb(DbContextOptions<AppContextDb> options) : base(options) { }

        public DbSet<User> Users { get; set; } 
    }
}
