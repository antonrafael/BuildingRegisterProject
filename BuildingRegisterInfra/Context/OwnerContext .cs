using BuildingRegisterDomain.Model.Entities;
using Microsoft.EntityFrameworkCore;


namespace BuildingRegisterInfra.Context
{
    public class ExpertiseContext : DbContext
    {
        public ExpertiseContext(DbContextOptions<BuildingContext> options) : base(options)
        {
        }

        public DbSet<Expertise> Expertises { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Expertise>()
                    .HasOne(c => c.Building);

            modelBuilder.Entity<Expertise>().Property(x => x.Id);
            modelBuilder.Entity<Expertise>().Property(x => x.Name).HasMaxLength(120).HasColumnType("varchar(120)");
            modelBuilder.Entity<Expertise>().Property(x => x.Building.Id);
        }
    }
}
