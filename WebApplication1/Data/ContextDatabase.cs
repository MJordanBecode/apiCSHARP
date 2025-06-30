using Microsoft.EntityFrameworkCore;

namespace DefaultNamespace
{
    public class ContextDatabase : DbContext
       {
           public ContextDatabase(DbContextOptions<ContextDatabase> options) : base(options) { }
       } 
}
