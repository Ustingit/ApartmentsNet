using System.ComponentModel.DataAnnotations;

namespace Apartments.Models.Postgres
{
    public class Company
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string OfficialName { get; set; }
        [Required]
        public int INN { get; set; }
        [Required]
        public int Phone { get; set; }
        [Required]
        public Adress Address { get; set; }
        public bool IsBelCompany { get; set; }
        public string Comment { get; set; }
        public bool IsVIP { get; set; } = false;
        public string Information { get; set; }
    }
}