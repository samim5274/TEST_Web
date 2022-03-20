using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TestDemoFast.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() :
            base("connStr")
        {
            
        }

        public DbSet<Student> StudentInformation { get; set; }
    }
}