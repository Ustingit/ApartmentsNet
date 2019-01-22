namespace Apartments.Models
{
    public class TempApartment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Price { get; set; }
        public int Phone { get; set; }
        public string Description { get; set; }
        public string DateCreated { get; set; }
        public string DateActualTo { get; set; }
        public bool IsActive { get; set; }
        public bool IsDonated { get; set; }
        public string DonateDueDate { get; set; }
        public string InternalComment { get; set; }
        public int? ClientId { get; set; }
        public int? ParsingSource { get; set; }
        public string ShortId { get; set; }
        public string SourceURL { get; set; }
        public string mainPhotoUrl { get; set; }
        public string photosListUrls { get; set; }
        public string phoneImgURL { get; set; }
    }
}