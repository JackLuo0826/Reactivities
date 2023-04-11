using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        // DbSet Activities represents Activities table in our DB
        public DbSet<Activity> Activities { get; set; }
    }
}
