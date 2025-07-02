using DefaultNamespace;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data
{
    public class ContextDatabase : DbContext
       {
           public ContextDatabase(DbContextOptions<ContextDatabase> options) : base(options)
           {
               
           }
           public virtual DbSet<User> Users { get; set; }
           public virtual DbSet<Address> Addresses { get; set; }
       } 
}
