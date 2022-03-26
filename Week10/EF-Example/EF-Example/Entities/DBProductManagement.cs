using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Example.Entities
{
    public class DBProductManagement : DbContext 
    {
        
        private static string _connString = "Data Source = BAHAU; Initial Catalog = STUDENT_MANAGEMENT; User ID = sa; Password=2411";
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connString);
        }
    }
}
