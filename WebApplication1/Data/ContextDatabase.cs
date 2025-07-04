using Microsoft.EntityFrameworkCore;
using WebApplication1.Entities;

namespace WebApplication1.Data
{
    public class ContextDatabase : DbContext
    {
        public ContextDatabase(DbContextOptions<ContextDatabase> options): base(options) { }

        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { //permet de créer des données fictives, il faut toujours mettre notre seed dans le dbContext comme ici
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