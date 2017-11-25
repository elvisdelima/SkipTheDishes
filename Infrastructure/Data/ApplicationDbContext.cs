using SkipTheDishes.Domain;
using Microsoft.EntityFrameworkCore;

namespace SkipTheDishes.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Taste> Tastes { get; set; }
    }
}