using System;
using System.Collections.Generic;
using System.Web;

namespace Apartments.Models
{
    public class Apartment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Price { get; set; }
        public int? Phone { get; set; }
        public int? ClientId { get; set; }
        public string Description { get; set; }
        public HttpPostedFileBase PhoneImg { get; set; }
        public byte[] MainApPhoto { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateActualTo { get; set; }
        public bool IsActive { get; set; }
        public bool IsDonated { get; set; }
        public DateTime DonateDueDate { get; set; }
        public string InternalComment { get; set; }
        //public ICollection<byte[]> Images { get; set; }
        //public Apartment()
        //{
        //    Images = new List<byte[]>();
        //}
    }
}