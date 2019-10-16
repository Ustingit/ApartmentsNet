namespace Apartments.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changestringPricetoIntPriceinrubles : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.Apartment",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        AuthorId = c.String(nullable: false),
                        IntPrice = c.Int(nullable: false),
                        Phone = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        DateCreated = c.DateTime(),
                        DateActualTo = c.DateTime(),
                        IsActive = c.Boolean(nullable: false),
                        IsDonated = c.Boolean(nullable: false),
                        DonateDueDate = c.DateTime(),
                        FollowersIds = c.String(),
                        AddressId = c.String(nullable: false),
                        ParsingSource = c.Int(),
                        ShortId = c.String(),
                        SourceURL = c.String(),
                        mainPhotoUrl = c.String(),
                        photosListUrls = c.String(),
                        phoneImgURL = c.String(),
                        Comment = c.String(),
                        Information = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("public.Apartment");
        }
    }
}
