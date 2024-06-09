using Microsoft.EntityFrameworkCore;
using Tests.Entities;

namespace Tests.DataBase
{
    public class ClassContext:DbContext
    {
        public ClassContext(DbContextOptions<ClassContext> options):base(options)
        {
                
        }
   
    
       public DbSet<Name> names { get; set; }
    
    
    
    
    
    
    }
}
