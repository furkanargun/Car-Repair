using CarRepair.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarRepair.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Brand> Brand { get; set; }

        public DbSet<Car> Car { get; set; }

        public DbSet<Color> Color { get; set; }

        public DbSet<EngineCapacity> EngineCapacity { get; set; }
        public DbSet<Gear> Gear { get; set; }
        public DbSet<KM> KM { get; set; }
        public DbSet<Model> Model { get; set; }
    }
}