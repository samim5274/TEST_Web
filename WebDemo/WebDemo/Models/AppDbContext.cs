using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebDemo.Models
{
    public class AppDbContext : DbContext
    {


        public AppDbContext() :
            base("name=connStr")
        {

        }

        public DbSet<StudentInfo> Students { get; set; }
    }
}