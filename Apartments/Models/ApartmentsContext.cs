using System.Data.Entity;

namespace Apartments.Models
{
    public class ApartmentsContext : DbContext
    {
        public DbSet<Apartment> Apartments  { get; set; }
        public DbSet<Client> Clients { get; set; }
    }
}