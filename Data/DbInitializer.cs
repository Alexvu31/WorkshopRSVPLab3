using Microsoft.EntityFrameworkCore;
using WorkshopRSVPLab3.Models;

namespace WorkshopRSVPLab3.Data
{
    public static class DbInitializer
    {
        public static void Seed(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Rsvps.Any())
            {
                return;
            }

            var rsvps = new Rsvp[]
            {
                new Rsvp
                {
                    FullName = "Alex Smith",
                    NeedsAccomodation = false,
                    WorkshopTitle = "Introduction to ASP.NET Core"
                },

                new Rsvp
                {
                    FullName = "Jordan Lee",
                    NeedsAccomodation = true,
                    WorkshopTitle = "Introduction to ASP.NET Core"
                },

                new Rsvp
                {
                    FullName = "Taylor Brown",
                    NeedsAccomodation = false,
                    WorkshopTitle = "Entity Framework Core"
                }
            };

            context.Rsvps.AddRange(rsvps);
            context.SaveChanges();
        }
    }
}
