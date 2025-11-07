using Microsoft.EntityFrameworkCore;
using SmpPharmacyServer.Models;

namespace SmpPharmacyServer.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Medication> Medications { get; set; }
        public DbSet<Brigade> Brigades { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<PackageMedication> PackageMedications { get; set; }
        public DbSet<Replenishment> Replenishments { get; set; }
    }
}
