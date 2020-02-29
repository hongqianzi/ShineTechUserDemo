using Microsoft.EntityFrameworkCore;
using ShineTech.Domain.Models.Users;
using ShineTech.Infrastructure.Repositories.Customers;

namespace ShineTech.Infrastructure.Repositories
{
    public class RentalContext : DbContext
    {
        public RentalContext(DbContextOptions<RentalContext> options)
           : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserEntityTypeConfiguration());
        }
    }
}
