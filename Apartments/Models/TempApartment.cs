using System.ComponentModel.DataAnnotations;

namespace Apartments.Models
{
    public class TempApartment
    {
        public int Id { get; set; }

        [Display(Name="Название")]
        public string Name { get; set; }
        [Display(Name = "Автор")]
        public string Author { get; set; }
        [Display(Name = "Цена")]
        public string Price { get; set; }
        [Display(Name = "Номер телефона владельца")]
        public int Phone { get; set; }
        [Display(Name = "Описание")]
        public string Description { get; set; }
        [Display(Name = "Дата создания")]
        public string DateCreated { get; set; }
        [Display(Name = "Дата окончания действия")]
        public string DateActualTo { get; set; }
        public bool IsActive { get; set; }
        public bool IsDonated { get; set; }
        public string DonateDueDate { get; set; }
        public string InternalComment { get; set; }
        public int? ClientId { get; set; }
        [Display(Name = "Источник объявления")]
        public int? ParsingSource { get; set; }
        public string ShortId { get; set; }
        public string SourceURL { get; set; }
        public string mainPhotoUrl { get; set; }
        public string photosListUrls { get; set; }
        public string phoneImgURL { get; set; }
    }
}