using BuildingRegisterDomain.Model.Entities;
using Microsoft.EntityFrameworkCore;


namespace BuildingRegisterInfra.Context
{
    public class OwnerContext : DbContext
    {
        public OwnerContext(DbContextOptions<BuildingContext> options) : base(options)
        {
        }

        public DbSet<Owner> Owners { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Owner>().Property(x => x.Id);
            modelBuilder.Entity<Owner>().Property(x => x.Name).HasMaxLength(120).HasColumnType("varchar(120)");
        }
    }
}
