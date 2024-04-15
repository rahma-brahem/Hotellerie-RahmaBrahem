using Microsoft.EntityFrameworkCore;

namespace Hotellerie_RahmaBrahem.Models.HotellerieModel
{
    public class HotellerieDbContext:DbContext
    {
        public HotellerieDbContext(DbContextOptions options) : base(options)
        {

        }

        protected HotellerieDbContext()
        {
        }

        public DbSet<Hotel> Hotels { get; set; } = null!;
        public DbSet<Appreciation> Appreciations { get; set; } = null!;

    }
}
