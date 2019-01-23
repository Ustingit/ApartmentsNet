using Apartments.Models.Pagination;
using System.Collections.Generic;

namespace Apartments.Models
{
    public class ApartmentsWithPagination
    {
        public IEnumerable<TempApartment> Apartments { get; set; }
        public PaginationModel PageInfo { get; set; }
    }
}