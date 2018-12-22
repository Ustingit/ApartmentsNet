using System;
using System.Collections.Generic;

namespace Apartments.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string FatherName { get; set; }
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