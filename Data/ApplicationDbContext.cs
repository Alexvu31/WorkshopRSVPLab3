using Microsoft.EntityFrameworkCore;
using WorkshopRSVPLab3.Models;

namespace WorkshopRSVPLab3.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Rsvp> Rsvps { get; set; }
    }
}