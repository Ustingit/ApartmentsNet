using System;
using System.Data.Entity;

namespace Apartments.Models
{
    public class ApartmentsDbInitializer : DropCreateDatabaseAlways<ApartmentsContext>
    {
        protected override void Seed(ApartmentsContext db)
        {
            db.Apartments.Add(new Apartment {
                Name = "Первая пробная квартира автоматом для дебага",
                Author = "Л. Толстой",
                Price = "220",
                Phone = 276487468,
                ClientId = 1,
                Description = "AZAZA",
                DateCreated = DateTime.UtcNow,
                DateActualTo = DateTime.UtcNow,
                DonateDueDate = DateTime.UtcNow,
                IsActive = true,
                IsDonated = false,
                InternalComment = "AH!"
            });
            db.Clients.Add(new Client {
                Name = "First debig client",
                SurName = "oloshevich",
                FatherName = "soloviev",
                Address = "skr 42",
                Agency = "realt",
                InternalComment = "jfytfk",
                Phone = 235345,
                RegistrationDate = DateTime.UtcNow
            });

            base.Seed(db);
        }
    }
}