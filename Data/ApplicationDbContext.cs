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
        public DbSet<Model> Model { get; set; }
        public DbSet<Brand> Brand { get; set; }
        //public DbSet<Brand> Brand { get; set; }
        //public DbSet<EngineCapacity> EngineCapacity { get; set; }
        //public DbSet<Gear> Gear { get; set; }
        
    }
}