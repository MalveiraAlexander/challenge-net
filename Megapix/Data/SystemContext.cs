using Megapix.Models;
using Microsoft.EntityFrameworkCore;

namespace Megapix.Data
{
    public class SystemContext : DbContext
    {
        public SystemContext(DbContextOptions<SystemContext> options, IConfiguration configuration)
            : base(options)
        {}

        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(300);

                entity.Property(e => e.Area).HasPrecision(15, 2);

                entity.Property(e => e.AllTimezones).HasColumnType("text");

                entity.Property(e => e.ContinentName).HasMaxLength(500);

                entity.Property(e => e.Latitude).HasPrecision(10, 7);

                entity.Property(e => e.Longitude).HasPrecision(10, 7);

                entity.Property(e => e.UpdatedAt).HasDefaultValueSql("now()");

                entity.ToTable("Countries");
            });
        }
    }
}
