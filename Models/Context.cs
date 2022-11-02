using Microsoft.EntityFrameworkCore;

namespace Turkcell.Models
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
                
        }

        public DbSet<Product> Products { get; set; }   
        public  DbSet<Profile> Profiles { get; set; }
    }
}
