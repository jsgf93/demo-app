using Microsoft.EntityFrameworkCore;
using demo_app_vs.Entities;

namespace demo_app_vs.Helpers
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
