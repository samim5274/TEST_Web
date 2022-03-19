using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Demo2.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() :
            base("name=connStr")
        {

        }

        public DbSet<StudentInfo> students { get; set; }
    }
}