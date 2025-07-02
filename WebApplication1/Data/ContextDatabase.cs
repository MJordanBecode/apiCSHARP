using Microsoft.EntityFrameworkCore;
using WebApplication1.Entities;

namespace WebApplication1.Data
{
    public class ContextUser : DbContext
    {
        public ContextUser(DbContextOptions<ContextUser> options): base(options) { }

        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development")
            {
                modelBuilder.Entity<User>().HasData(
                    new User
                    {
                        Id = 1, // Ensure IDs are provided for seeding
                        FirstName = "John",
                        LastName = "Doe",
                        Email = "johndoe@domain.be"
                    }
                );
            }
        }
    }
}