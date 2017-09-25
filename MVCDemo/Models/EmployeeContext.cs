using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext()
            : base("name=employConn")
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}