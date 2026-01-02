using Microsoft.EntityFrameworkCore;

namespace _EF_Filter_Session_WEBApi.Models
{
    public class DACContext:DbContext
    {
        public DbSet<Emp> emps { get; set; }
        public DACContext(DbContextOptions options):base(options) 
        {
            
        }
    }
}
