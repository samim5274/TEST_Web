using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DemoDormitory.Models
{
    public class AppDbContext : DbContext 
    {
        public DbSet<StudentInformation> StudentInformations { get; set; }

        public AppDbContext() : 
            base("name=connStr")
        {

        }
    }
}