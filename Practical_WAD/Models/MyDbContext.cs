using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Practical_WAD.Models
{
    public class MyDbContext: DbContext
    {
        public MyDbContext()
           : base("MyConnectionString")
        {
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}