using AUTH_SERVICE_DOMAIN.Entities.Audit;
using AUTH_SERVICE_DOMAIN.Entities.User;
using Microsoft.EntityFrameworkCore;

namespace AUTH_SERVICE_INFRASTRUCTURE.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }

        public DbSet<UserEntity> Users { get; set; }
        public DbSet<LogEntity> Logs { get; set; }

    }
}
