using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Apartments.Models.Postgres
{
    public class Apartment
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Название")]
        public string Name { get; set; }
        [Required]
        public Client Author { get; set; }
        [Required]
        public string Price { get; set; }
        [Required]
        public int Phone { get; set; }
        [Required]
        [Display(Name = "Описание")]
        public string Description { get; set; }
        [Display(Name = "Дата создания")]
        public DateTime DateCreated { get; set; }
        [Display(Name = "Дата окончания действия")]
        public DateTime DateActualTo { get; set; }
        public bool IsActive { get; set; } = false;
        public bool IsDonated { get; set; } = false;
        public DateTime DonateDueDate { get; set; }
        public List<Client> Followers { get; set; }


        [Display(Name = "Источник объявления")]
        public int? ParsingSource { get; set; }
        public string ShortId { get; set; }
        public string SourceURL { get; set; }
        public string mainPhotoUrl { get; set; }
        public string photosListUrls { get; set; }
        public string phoneImgURL { get; set; }
        public string Comment { get; set; }
        public string Information { get; set; }
    }
}