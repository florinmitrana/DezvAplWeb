using Microsoft.EntityFrameworkCore;

namespace Tema3.Model
{
    public class DB : DbContext
    {
        public DbSet<Student> students { get; set; }

        public DB(DbContextOptions options) : base(options) { 
        
        }
    }
}
