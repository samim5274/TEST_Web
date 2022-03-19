using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ssssssssssssss.Models
{
    public class AppDbContext : DbContext
    {

        public DbSet<Department> Departments { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Std> Stds { get; set; }

        public AppDbContext(): 
            base ("name=connstr")
        {

        }
    }
}