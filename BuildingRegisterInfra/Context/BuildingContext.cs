using BuildingRegisterDomain.Model.Entities;
using Microsoft.EntityFrameworkCore;


namespace BuildingRegisterInfra.Context
{
    public class BuildingContext : DbContext
    {
        public BuildingContext(DbContextOptions<BuildingContext> options) : base(options)
        {
        }

        public DbSet<Building> Buildings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Building>()
                    .HasMany(c => c.Expertises)
                    .WithOne(e => e.Building);

            modelBuilder.Entity<Building>()
                    .HasMany(c => c.Expertises)
                    .WithOne(e => e.Building);

            modelBuilder.Entity<Building>().Property(x => x.Id);
            modelBuilder.Entity<Building>().Property(x => x.Name).HasMaxLength(120).HasColumnType("varchar(120)");
            modelBuilder.Entity<Building>().Property(x => x.BuildingOwner.Id);
            modelBuilder.Entity<Building>().Property(x => x.Address).HasColumnType("varchar(160)");
        }
    }
}
