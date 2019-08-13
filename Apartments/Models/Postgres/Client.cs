using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Apartments.Models.Postgres
{
    public class Client    //done v v2
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
        public string PaymentsIds { get; set; }   //public ICollection<string> PaymentsIds { get; set; }  //public ICollection<Payment> Payments { get; set; }  for simplify temporary: TOTO how to manage it as object ? what type of relations ? many-to-many ? many-to-one ?
        public bool IsVip { get; set; }
        [Required]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Некорректный адрес")]
        public string Email { get; set; }
        
        public string AddressId { get; set; }  //public Adress Address { get; set; }
        public string Agency { get; set; }
        public string InternalComment { get; set; }
        [Required]
        public int Phone { get; set; }
        public DateTime RegistrationDate { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        public bool IsAgent { get; set; }
        public bool IsDonated { get; set; }
        public int AvatarId { get; set; }

        public string ApartmentsIds { get; set; }   //public ICollection<string> ApartmentsIds { get; set; }   //public ICollection<Apartment> ClientApartments { get; set; }
        //public Client() {  ApartmentsIds = new List<string>();  PaymentsIds = new List<string>(); }
    }
}