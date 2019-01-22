using System.Data.Entity;

namespace Apartments.Models
{
    public class ApartmentsTemporaryContext : DbContext
    {
        public DbSet<TempApartment> Apartments { get; set; }
        public DbSet<TempClient> Clients { get; set; }
    }
}