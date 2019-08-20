using System.Collections.Generic;

namespace Apartments.Models.Postgres
{
    public class DomainApartment
    {
        public IEnumerable<Apartment> Apartments { get; set; }
        public PageInfo PageInfo { get; set; }
    }
}