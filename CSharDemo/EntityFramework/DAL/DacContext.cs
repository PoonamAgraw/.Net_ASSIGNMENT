using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EntityFramework.DAL
{
    public class DacContext :DbContext
    {
        public DbSet<Emp> emps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            var builder = new ConfigurationBuilder();

            
            builder.SetBasePath(Directory.GetCurrentDirectory());

            
            builder.AddJsonFile("appsettings.json");

           
            IConfiguration config = builder.Build();

            

            optionsBuilder.UseSqlServer(config.GetConnectionString("Dac"));
        }
    }
}
