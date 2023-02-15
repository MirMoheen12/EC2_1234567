using Microsoft.EntityFrameworkCore;

namespace EC2_1234567.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }
        public DbSet<ApplicationSoftware> applicationSoftwares { get; set; }

    }
}
