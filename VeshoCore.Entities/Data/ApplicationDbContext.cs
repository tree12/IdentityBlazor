using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace VeshoCore.Entities.Data
{
    public class ApplicationDbContext : IdentityDbContext<VeshoIdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<VeshoIdentityUser> VeshoIdentityUsers { get; set; }
    }
}
