using ApiHorusPrueba.Model;
using Microsoft.EntityFrameworkCore;

namespace ApiHorusPrueba.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Rooms> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }

    }

}

