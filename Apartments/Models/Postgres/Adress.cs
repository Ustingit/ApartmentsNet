using System.ComponentModel.DataAnnotations;

namespace Apartments.Models.Postgres
{
    public class Adress
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string City { get; set; }
        public string PlaceName { get; set; } // название места
        public double Traffic { get; set; } // пассажиропоток
        public string District { get; set; }
        public string MetroLine { get; set; } // линия метро
        public double GeoLong { get; set; } // долгота - для карт google
        public double GeoLat { get; set; } // широта - для карт google
        public string Information { get; set; }
        public string Comment { get; set; }
    }
}