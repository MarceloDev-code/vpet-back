using Microsoft.EntityFrameworkCore;
using VPetBackend.Models;
namespace VPetBackend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<Pet> Pets => Set<Pet>();
        public DbSet<VPetBackend.Models.User> Users => Set<VPetBackend.Models.User>();
    }
}
