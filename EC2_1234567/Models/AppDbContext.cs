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
        public DbSet<BagStore> bagStores { get; set; }
        public DbSet<BookStore> bookStores { get; set; }
        public DbSet<LaptopStore> laptopStores { get; set; }
        public DbSet<PhoneStore> phoneStores { get; set; }
        public DbSet<ShoeStore> shoeStores { get; set; }
        public DbSet<Vehicle> vehicles { get; set; }
        public DbSet<WatchStore> watchStores { get; set; }
    }
}
