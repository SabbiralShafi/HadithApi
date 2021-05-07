using Microsoft.EntityFrameworkCore;

namespace HadithApi.Data
{
    public class HadithApiContext : DbContext
    {
        public HadithApiContext(DbContextOptions<HadithApiContext> options)
            : base(options)
        {
        }

        public DbSet<Hadith> Hadith { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
