using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Apartments.Models.Postgres
{
    public class Client
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Длина имени должна быть от 2 до 50 символов")]
        public string Name { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Длина фамилии должна быть от 2 до 50 символов")]
        public string SurName { get; set; }
        public string FatherName { get; set; }
        public List<Payment> Payments { get; set; }
        public bool IsVip { get; set; }
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Некорректный адрес")]
        public string Email { get; set; }

        
        
        
        public string Address { get; set; }
        public string Agency { get; set; }
        public string InternalComment { get; set; }
        public int Phone { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsAgent { get; set; }
        public bool IsDonated { get; set; }
        public int AvatarId { get; set; }

        public ICollection<Apartment> ClientApartments { get; set; }
        public Client()
        {
            ClientApartments = new List<Apartment>();
        }
    }
}