using _FilterSession.Models;
using Microsoft.EntityFrameworkCore;

namespace _FilterSession.Models
{
    public class IETDbContext: DbContext
    {
        public DbSet<Emp> emps { get; set; }

        public IETDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
