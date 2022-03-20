using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TestDemo.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() :
            base("ConnStr")
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}