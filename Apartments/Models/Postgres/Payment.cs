using System;
using System.ComponentModel.DataAnnotations;

namespace Apartments.Models.Postgres
{
    [Serializable]
    public class Payment
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [Range(typeof(double), "0.00", "1844674407.99")]
        public double Sum { get; set; } = 0;
        [Required]
        public Client Sender { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public bool IsCompleted { get; set; } = false;
        public string Information { get; set; }
        public string Check { get; set; }
        public string Comment { get; set; }
    }
}