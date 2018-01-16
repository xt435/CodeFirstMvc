using CodeFirstMvc.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstMvc.Data
{
    public class ContosoDbContext : DbContext
    {
        public ContosoDbContext() : base("Name=ContosoDbContext")
        {
            // this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<People> People { get; set; }
        public DbSet<Department> Department  { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Student> Student { get; set; }
    }
}
