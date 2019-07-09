using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Apartments.Models
{
    public class ApartmentsTemporaryContext : DbContext
    {
        public DbSet<Postgres.Apartment> Apartments { get; set; }
        public DbSet<Postgres.Client> Clients { get; set; }
        public DbSet<Postgres.Adress> Addresses { get; set; }
        public DbSet<Postgres.Company> Companies { get; set; }
        public DbSet<Postgres.Payment> Payments { get; set; }

        public ApartmentsTemporaryContext() : base("ApartmentsTemporaryContext") { }

        public static ApartmentsTemporaryContext Create()
        {
            return new ApartmentsTemporaryContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);

            Database.SetInitializer<ApartmentsTemporaryContext>(null);
        }
    }
}