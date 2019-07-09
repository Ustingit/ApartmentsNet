using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Apartments.Models
{
    public class Client
    {
        [Required]
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string SurName { get; set; }
        public string FatherName { get; set; }
        public string Address { get; set; }
        public string Agency { get; set; }
        public string InternalComment { get; set; }
        [Required]
        public int Phone { get; set; }
        [Required]
        public DateTime RegistrationDate { get; set; }
        [Required]
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